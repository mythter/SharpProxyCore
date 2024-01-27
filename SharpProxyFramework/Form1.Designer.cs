using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SharpProxyFramework
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInternalPort = new System.Windows.Forms.TextBox();
            this.txtExternalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIPAddress = new System.Windows.Forms.ComboBox();
            this.chkRewriteHostHeaders = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIPAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComboIPAddress = new System.Windows.Forms.ToolStripComboBox();
            this.menuExternalPort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTxtExternalPort = new System.Windows.Forms.ToolStripTextBox();
            this.menuInternalPort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTxtInternalPort = new System.Windows.Forms.ToolStripTextBox();
            this.menuRewriteHostHeaders = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(21, 176);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(181, 176);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your IP Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInternalPort);
            this.panel1.Controls.Add(this.txtExternalPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIPAddress);
            this.panel1.Controls.Add(this.chkRewriteHostHeaders);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 218);
            this.panel1.TabIndex = 3;
            // 
            // txtInternalPort
            // 
            this.txtInternalPort.Location = new System.Drawing.Point(21, 121);
            this.txtInternalPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInternalPort.Name = "txtInternalPort";
            this.txtInternalPort.Size = new System.Drawing.Size(290, 22);
            this.txtInternalPort.TabIndex = 8;
            this.txtInternalPort.TextChanged += new System.EventHandler(this.InternalPort_TextChanged);
            this.txtInternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            // 
            // txtExternalPort
            // 
            this.txtExternalPort.Location = new System.Drawing.Point(21, 74);
            this.txtExternalPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExternalPort.Name = "txtExternalPort";
            this.txtExternalPort.Size = new System.Drawing.Size(290, 22);
            this.txtExternalPort.TabIndex = 7;
            this.txtExternalPort.TextChanged += new System.EventHandler(this.ExternalPort_TextChanged);
            this.txtExternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Internal Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "External Port";
            // 
            // cmbIPAddress
            // 
            this.cmbIPAddress.FormattingEnabled = true;
            this.cmbIPAddress.Location = new System.Drawing.Point(21, 26);
            this.cmbIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIPAddress.Name = "cmbIPAddress";
            this.cmbIPAddress.Size = new System.Drawing.Size(290, 24);
            this.cmbIPAddress.TabIndex = 4;
            this.cmbIPAddress.SelectedIndexChanged += new System.EventHandler(this.IPAddress_SelectedIndexChanged);
            // 
            // chkRewriteHostHeaders
            // 
            this.chkRewriteHostHeaders.AutoSize = true;
            this.chkRewriteHostHeaders.Location = new System.Drawing.Point(21, 150);
            this.chkRewriteHostHeaders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRewriteHostHeaders.Name = "chkRewriteHostHeaders";
            this.chkRewriteHostHeaders.Size = new System.Drawing.Size(233, 20);
            this.chkRewriteHostHeaders.TabIndex = 3;
            this.chkRewriteHostHeaders.Text = "Rewrite host headers (IIS Express)";
            this.chkRewriteHostHeaders.UseVisualStyleBackColor = true;
            this.chkRewriteHostHeaders.CheckedChanged += new System.EventHandler(this.RewriteHostHeaders_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SharpProxyCore";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuStop,
            this.menuIPAddress,
            this.menuExternalPort,
            this.menuInternalPort,
            this.menuRewriteHostHeaders,
            this.menuExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(217, 172);
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(216, 24);
            this.menuStart.Text = "Start";
            this.menuStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStop
            // 
            this.menuStop.Enabled = false;
            this.menuStop.Name = "menuStop";
            this.menuStop.Size = new System.Drawing.Size(216, 24);
            this.menuStop.Text = "Stop";
            this.menuStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // menuIPAddress
            // 
            this.menuIPAddress.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuComboIPAddress});
            this.menuIPAddress.Name = "menuIPAddress";
            this.menuIPAddress.Size = new System.Drawing.Size(216, 24);
            this.menuIPAddress.Text = "IP Address";
            // 
            // menuComboIPAddress
            // 
            this.menuComboIPAddress.Name = "menuComboIPAddress";
            this.menuComboIPAddress.Size = new System.Drawing.Size(121, 28);
            this.menuComboIPAddress.SelectedIndexChanged += new System.EventHandler(this.IPAddress_SelectedIndexChanged);
            // 
            // menuExternalPort
            // 
            this.menuExternalPort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTxtExternalPort});
            this.menuExternalPort.Name = "menuExternalPort";
            this.menuExternalPort.Size = new System.Drawing.Size(216, 24);
            this.menuExternalPort.Text = "External Port";
            // 
            // menuTxtExternalPort
            // 
            this.menuTxtExternalPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuTxtExternalPort.Name = "menuTxtExternalPort";
            this.menuTxtExternalPort.Size = new System.Drawing.Size(100, 27);
            this.menuTxtExternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            this.menuTxtExternalPort.TextChanged += new System.EventHandler(this.ExternalPort_TextChanged);
            // 
            // menuInternalPort
            // 
            this.menuInternalPort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTxtInternalPort});
            this.menuInternalPort.Name = "menuInternalPort";
            this.menuInternalPort.Size = new System.Drawing.Size(216, 24);
            this.menuInternalPort.Text = "Internal Port";
            // 
            // menuTxtInternalPort
            // 
            this.menuTxtInternalPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuTxtInternalPort.Name = "menuTxtInternalPort";
            this.menuTxtInternalPort.Size = new System.Drawing.Size(100, 27);
            this.menuTxtInternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            this.menuTxtInternalPort.TextChanged += new System.EventHandler(this.InternalPort_TextChanged);
            // 
            // menuRewriteHostHeaders
            // 
            this.menuRewriteHostHeaders.Name = "menuRewriteHostHeaders";
            this.menuRewriteHostHeaders.Size = new System.Drawing.Size(216, 24);
            this.menuRewriteHostHeaders.Text = "Rewrite host headers";
            this.menuRewriteHostHeaders.Click += new System.EventHandler(this.menuRewriteHostHeaders_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(216, 24);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.Close);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 218);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SharpProxyCore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private Panel panel1;
        private TextBox txtInternalPort;
        private TextBox txtExternalPort;
        private Label label3;
        private Label label2;
        private ComboBox cmbIPAddress;
        private CheckBox chkRewriteHostHeaders;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem menuIPAddress;
        private ToolStripComboBox menuComboIPAddress;
        private ToolStripMenuItem menuExternalPort;
        private ToolStripMenuItem menuStart;
        private ToolStripMenuItem menuInternalPort;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuStop;
        private ToolStripTextBox menuTxtExternalPort;
        private ToolStripTextBox menuTxtInternalPort;
        private ToolStripMenuItem menuRewriteHostHeaders;
    }
}
