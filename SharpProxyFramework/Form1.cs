using System.Collections.Generic;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Linq;

namespace SharpProxyFramework
{
    public partial class frmMain : Form
    {
        private const int MIN_PORT = 1;
        private const int MAX_PORT = 65535;

        public static readonly string CommonDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "SharpProxy");
        public static readonly string ConfigInfoPath = Path.Combine(CommonDataPath, "config.txt");

        private ProxyThread ProxyThreadListener = null;

        private bool RewriteHostHeaders;
        private int ExternalPort;
        private int InternalPort;

        public frmMain()
        {
            InitializeComponent();

            var ips = getLocalIPs().OrderBy(x => x);
            if (ips.Any())
            {
                cmbIPAddress.Items.Clear();
                menuComboIPAddress.Items.Clear();
                foreach (string ip in ips)
                {
                    cmbIPAddress.Items.Add(ip);
                    menuComboIPAddress.Items.Add(ip);
                }
                cmbIPAddress.Text = cmbIPAddress.Items[0]?.ToString();
                menuComboIPAddress.Text = menuComboIPAddress.Items[0]?.ToString();
            }

            int port = 5000;
            while (!checkPortAvailability(port))
            {
                port++;
            }
            ExternalPort = port;
            SetExternalPort();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtInternalPort.Focus();

            //Try to load config
            try
            {
                using (StreamReader sr = new StreamReader(ConfigInfoPath))
                {
                    var values = sr.ReadToEnd().Split('\n')
                                               .Select(x => x.Trim())
                                               .ToArray();

                    if (int.TryParse(values[0], out InternalPort))
                    {
                        SetInternalPort();
                    }
                    RewriteHostHeaders = bool.Parse(values[1]);
                    SetRewriteHostHeaders();
                }
            }
            catch { }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProxyThreadListener != null)
            {
                ProxyThreadListener.Stop();
            }

            //Try to save config
            try
            {
                if (!Directory.Exists(CommonDataPath))
                {
                    Directory.CreateDirectory(CommonDataPath);
                }
                using (StreamWriter sw = new StreamWriter(ConfigInfoPath))
                {
                    sw.WriteLine(InternalPort);
                    sw.WriteLine(RewriteHostHeaders);
                }
            }
            catch { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!checkPortRange(ExternalPort)
                || !checkPortRange(InternalPort)
                || ExternalPort == InternalPort)
            {
                showError("Ports must be between " + MIN_PORT + "-" + MAX_PORT + " and must not be the same.");
                return;
            }
            if (!checkPortAvailability(ExternalPort))
            {
                showError("Port " + ExternalPort + " is not available, please select a different port.");
                return;
            }

            ProxyThreadListener = new ProxyThread(ExternalPort, InternalPort, RewriteHostHeaders);

            toggleButtons();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ProxyThreadListener?.Stop();

            toggleButtons();
        }

        private void showError(string msg)
        {
            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool checkPortRange(int port)
        {
            if (port < MIN_PORT || port > MAX_PORT)
                return false;
            return true;
        }

        private List<string> getLocalIPs()
        {
            //Try to find our internal IP address...
            string myHost = System.Net.Dns.GetHostName();
            IPAddress[] addresses = System.Net.Dns.GetHostEntry(myHost).AddressList;
            List<string> myIPs = new List<string>();
            string fallbackIP = "";

            for (int i = 0; i < addresses.Length; i++)
            {
                //Is this a valid IPv4 address?
                if (addresses[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    string thisAddress = addresses[i].ToString();
                    //Loopback is not our preference...
                    if (thisAddress == "127.0.0.1")
                        continue;
                    //169.x.x.x addresses are self-assigned "private network" IP by Windows
                    if (thisAddress.StartsWith("169"))
                    {
                        fallbackIP = thisAddress;
                        continue;
                    }
                    myIPs.Add(thisAddress);
                }
            }
            if (myIPs.Count == 0 && !string.IsNullOrEmpty(fallbackIP))
            {
                myIPs.Add(fallbackIP);
            }

            return myIPs;
        }

        private void toggleButtons()
        {
            btnStop.Enabled = !btnStop.Enabled;
            btnStart.Enabled = !btnStart.Enabled;
            menuStop.Enabled = !menuStop.Enabled;
            menuStart.Enabled = !menuStart.Enabled;
            txtExternalPort.Enabled = !txtExternalPort.Enabled;
            txtInternalPort.Enabled = !txtInternalPort.Enabled;
            menuExternalPort.Enabled = !menuExternalPort.Enabled;
            menuInternalPort.Enabled = !menuInternalPort.Enabled;
            chkRewriteHostHeaders.Enabled = !chkRewriteHostHeaders.Enabled;
            menuRewriteHostHeaders.Enabled = !menuRewriteHostHeaders.Enabled;
        }

        private bool checkPortAvailability(int port)
        {
            //http://stackoverflow.com/questions/570098/in-c-how-to-check-if-a-tcp-port-is-available

            // Evaluate current system tcp connections. This is the same information provided
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                    return false;
            }

            try
            {
                TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, port));
                listener.Start();
                listener.Stop();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void txtPorts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnStart_Click(null, null);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void IPAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prop = sender.GetType().GetProperty("SelectedIndex");
            if (prop != null)
            {
                int index = (int?)prop.GetValue(sender) ?? cmbIPAddress.SelectedIndex;
                if (index >= 0 && index < cmbIPAddress.Items.Count)
                {
                    cmbIPAddress.SelectedIndex = index;
                    menuComboIPAddress.SelectedIndex = index;
                }
            }
        }

        private void RewriteHostHeaders_CheckedChanged(object sender, EventArgs e)
        {
            var prop = sender.GetType().GetProperty("Checked");
            if (prop != null)
            {
                bool state = (bool?)prop.GetValue(sender) ?? false;
                RewriteHostHeaders = state;
                SetRewriteHostHeaders();
            }
        }

        private void menuRewriteHostHeaders_Click(object sender, EventArgs e)
        {
            bool state = menuRewriteHostHeaders.Checked;
            RewriteHostHeaders = !state;
            SetRewriteHostHeaders();
        }

        private void SetExternalPort()
        {
            txtExternalPort.Text = ExternalPort.ToString();
            menuTxtExternalPort.Text = ExternalPort.ToString();
        }

        private void SetInternalPort()
        {
            txtInternalPort.Text = InternalPort.ToString();
            menuTxtInternalPort.Text = InternalPort.ToString();
        }

        private void SetRewriteHostHeaders()
        {
            chkRewriteHostHeaders.Checked = RewriteHostHeaders;
            menuRewriteHostHeaders.Checked = RewriteHostHeaders;
        }

        private void ExternalPort_TextChanged(object sender, EventArgs e)
        {
            Port_TextChanged(sender, PortType.External);
        }

        private void InternalPort_TextChanged(object sender, EventArgs e)
        {
            Port_TextChanged(sender, PortType.Internal);
        }

        private void Port_TextChanged(object sender, PortType type)
        {
            var prop = sender.GetType().GetProperty("Text");
            if (prop != null)
            {
                string port = (string)prop.GetValue(sender) ?? "";
                if (type == PortType.External)
                {
                    ExternalPort = int.TryParse(port, out int exPort) ? exPort : ExternalPort;
                    SetExternalPort();
                }
                else if (type == PortType.Internal)
                {
                    InternalPort = int.TryParse(port, out int inPort) ? inPort : InternalPort;
                    SetInternalPort();
                }
            }
        }
    }
}
