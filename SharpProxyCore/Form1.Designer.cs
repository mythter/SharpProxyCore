namespace SharpProxyCore
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            panel1 = new Panel();
            txtInternalPort = new TextBox();
            txtExternalPort = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbIPAddress = new ComboBox();
            chkRewriteHostHeaders = new CheckBox();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            menuStart = new ToolStripMenuItem();
            menuStop = new ToolStripMenuItem();
            menuIPAddress = new ToolStripMenuItem();
            menuComboIPAddress = new ToolStripComboBox();
            menuExternalPort = new ToolStripMenuItem();
            menuTxtExternalPort = new ToolStripTextBox();
            menuInternalPort = new ToolStripMenuItem();
            menuTxtInternalPort = new ToolStripTextBox();
            menuRewriteHostHeaders = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart.Location = new Point(21, 220);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 40);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStop.Location = new Point(181, 220);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(130, 40);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 6);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Your IP Address";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtInternalPort);
            panel1.Controls.Add(txtExternalPort);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbIPAddress);
            panel1.Controls.Add(chkRewriteHostHeaders);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnStart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 273);
            panel1.TabIndex = 3;
            // 
            // txtInternalPort
            // 
            txtInternalPort.Location = new Point(21, 151);
            txtInternalPort.Name = "txtInternalPort";
            txtInternalPort.Size = new Size(290, 27);
            txtInternalPort.TabIndex = 8;
            txtInternalPort.TextChanged += InternalPort_TextChanged;
            // 
            // txtExternalPort
            // 
            txtExternalPort.Location = new Point(21, 92);
            txtExternalPort.Name = "txtExternalPort";
            txtExternalPort.Size = new Size(290, 27);
            txtExternalPort.TabIndex = 7;
            txtExternalPort.TextChanged += ExternalPort_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 125);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Internal Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "External Port";
            // 
            // cmbIPAddress
            // 
            cmbIPAddress.FormattingEnabled = true;
            cmbIPAddress.Location = new Point(21, 32);
            cmbIPAddress.Name = "cmbIPAddress";
            cmbIPAddress.Size = new Size(290, 28);
            cmbIPAddress.TabIndex = 4;
            cmbIPAddress.SelectedIndexChanged += IPAddress_SelectedIndexChanged;
            // 
            // chkRewriteHostHeaders
            // 
            chkRewriteHostHeaders.AutoSize = true;
            chkRewriteHostHeaders.Location = new Point(21, 187);
            chkRewriteHostHeaders.Name = "chkRewriteHostHeaders";
            chkRewriteHostHeaders.Size = new Size(252, 24);
            chkRewriteHostHeaders.TabIndex = 3;
            chkRewriteHostHeaders.Text = "Rewrite host headers (IIS Express)";
            chkRewriteHostHeaders.UseVisualStyleBackColor = true;
            chkRewriteHostHeaders.CheckedChanged += RewriteHostHeaders_CheckedChanged;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "SharpProxyCore";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { menuStart, menuStop, menuIPAddress, menuExternalPort, menuInternalPort, menuRewriteHostHeaders, menuExit });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(217, 200);
            // 
            // menuStart
            // 
            menuStart.Name = "menuStart";
            menuStart.Size = new Size(216, 24);
            menuStart.Text = "Start";
            menuStart.Click += btnStart_Click;
            // 
            // menuStop
            // 
            menuStop.Enabled = false;
            menuStop.Name = "menuStop";
            menuStop.Size = new Size(216, 24);
            menuStop.Text = "Stop";
            menuStop.Click += btnStop_Click;
            // 
            // menuIPAddress
            // 
            menuIPAddress.DropDownItems.AddRange(new ToolStripItem[] { menuComboIPAddress });
            menuIPAddress.Name = "menuIPAddress";
            menuIPAddress.Size = new Size(216, 24);
            menuIPAddress.Text = "IP Address";
            // 
            // menuComboIPAddress
            // 
            menuComboIPAddress.Name = "menuComboIPAddress";
            menuComboIPAddress.Size = new Size(121, 28);
            menuComboIPAddress.SelectedIndexChanged += IPAddress_SelectedIndexChanged;
            // 
            // menuExternalPort
            // 
            menuExternalPort.DropDownItems.AddRange(new ToolStripItem[] { menuTxtExternalPort });
            menuExternalPort.Name = "menuExternalPort";
            menuExternalPort.Size = new Size(216, 24);
            menuExternalPort.Text = "External Port";
            // 
            // menuTxtExternalPort
            // 
            menuTxtExternalPort.Name = "menuTxtExternalPort";
            menuTxtExternalPort.Size = new Size(100, 27);
            menuTxtExternalPort.KeyPress += txtPorts_KeyPress;
            menuTxtExternalPort.TextChanged += ExternalPort_TextChanged;
            // 
            // menuInternalPort
            // 
            menuInternalPort.DropDownItems.AddRange(new ToolStripItem[] { menuTxtInternalPort });
            menuInternalPort.Name = "menuInternalPort";
            menuInternalPort.Size = new Size(216, 24);
            menuInternalPort.Text = "Internal Port";
            // 
            // menuTxtInternalPort
            // 
            menuTxtInternalPort.Name = "menuTxtInternalPort";
            menuTxtInternalPort.Size = new Size(100, 27);
            menuTxtInternalPort.KeyPress += txtPorts_KeyPress;
            menuTxtInternalPort.TextChanged += InternalPort_TextChanged;
            // 
            // menuRewriteHostHeaders
            // 
            menuRewriteHostHeaders.Name = "menuRewriteHostHeaders";
            menuRewriteHostHeaders.Size = new Size(216, 24);
            menuRewriteHostHeaders.Text = "Rewrite host headers";
            menuRewriteHostHeaders.Click += menuRewriteHostHeaders_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(216, 24);
            menuExit.Text = "Exit";
            menuExit.Click += Close;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 273);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "SharpProxyCore";
            FormClosing += frmMain_FormClosing;
            Shown += frmMain_Shown;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
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
