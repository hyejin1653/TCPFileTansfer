using System.Windows.Forms;

namespace File_Transfer.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.MainTabPage = new System.Windows.Forms.TabControl();
            this.TabPageReceiver = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripReceiver = new System.Windows.Forms.StatusStrip();
            this.labelReceivedProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarReceiveFile = new System.Windows.Forms.ToolStripProgressBar();
            this.btnReceiveFile = new System.Windows.Forms.Button();
            this.txtReceivePort = new System.Windows.Forms.TextBox();
            this.txtReceiveIpAdress = new System.Windows.Forms.TextBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.labelReceiverPort = new System.Windows.Forms.Label();
            this.labelReceiverIPAdress = new System.Windows.Forms.Label();
            this.labelSaveLocation = new System.Windows.Forms.Label();
            this.btnSelectSaveLocation = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSendRiskyJson = new System.Windows.Forms.Button();
            this.SendPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSendIp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSendFile = new System.Windows.Forms.Button();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.txtSendIpAdress = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.MainTabPage.SuspendLayout();
            this.TabPageReceiver.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStripReceiver.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.TabPageReceiver);
            this.MainTabPage.Controls.Add(this.tabPage1);
            this.MainTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainTabPage.Location = new System.Drawing.Point(0, 0);
            this.MainTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            this.MainTabPage.Size = new System.Drawing.Size(433, 463);
            this.MainTabPage.TabIndex = 2;
            // 
            // TabPageReceiver
            // 
            this.TabPageReceiver.Controls.Add(this.groupBox1);
            this.TabPageReceiver.Controls.Add(this.statusStripReceiver);
            this.TabPageReceiver.Controls.Add(this.btnReceiveFile);
            this.TabPageReceiver.Controls.Add(this.txtReceivePort);
            this.TabPageReceiver.Controls.Add(this.txtReceiveIpAdress);
            this.TabPageReceiver.Controls.Add(this.txtSaveLocation);
            this.TabPageReceiver.Controls.Add(this.labelReceiverPort);
            this.TabPageReceiver.Controls.Add(this.labelReceiverIPAdress);
            this.TabPageReceiver.Controls.Add(this.labelSaveLocation);
            this.TabPageReceiver.Controls.Add(this.btnSelectSaveLocation);
            this.TabPageReceiver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabPageReceiver.Location = new System.Drawing.Point(4, 26);
            this.TabPageReceiver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageReceiver.Name = "TabPageReceiver";
            this.TabPageReceiver.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageReceiver.Size = new System.Drawing.Size(425, 433);
            this.TabPageReceiver.TabIndex = 2;
            this.TabPageReceiver.Text = "Receive Data";
            this.TabPageReceiver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 186);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사고정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "수신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "26000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // statusStripReceiver
            // 
            this.statusStripReceiver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStripReceiver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelReceivedProgress,
            this.progressBarReceiveFile});
            this.statusStripReceiver.Location = new System.Drawing.Point(4, 408);
            this.statusStripReceiver.Name = "statusStripReceiver";
            this.statusStripReceiver.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripReceiver.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripReceiver.Size = new System.Drawing.Size(417, 22);
            this.statusStripReceiver.TabIndex = 29;
            this.statusStripReceiver.Text = "statusStripReceiver";
            // 
            // labelReceivedProgress
            // 
            this.labelReceivedProgress.Name = "labelReceivedProgress";
            this.labelReceivedProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBarReceiveFile
            // 
            this.progressBarReceiveFile.Name = "progressBarReceiveFile";
            this.progressBarReceiveFile.Size = new System.Drawing.Size(117, 16);
            this.progressBarReceiveFile.Visible = false;
            // 
            // btnReceiveFile
            // 
            this.btnReceiveFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceiveFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceiveFile.Location = new System.Drawing.Point(9, 138);
            this.btnReceiveFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReceiveFile.Name = "btnReceiveFile";
            this.btnReceiveFile.Size = new System.Drawing.Size(400, 42);
            this.btnReceiveFile.TabIndex = 26;
            this.btnReceiveFile.Text = "Wait for File...";
            this.btnReceiveFile.UseVisualStyleBackColor = true;
            this.btnReceiveFile.Click += new System.EventHandler(this.BtnReceiveFile_Click);
            // 
            // txtReceivePort
            // 
            this.txtReceivePort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceivePort.Location = new System.Drawing.Point(274, 92);
            this.txtReceivePort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReceivePort.Name = "txtReceivePort";
            this.txtReceivePort.Size = new System.Drawing.Size(135, 22);
            this.txtReceivePort.TabIndex = 25;
            this.txtReceivePort.Text = "25251";
            // 
            // txtReceiveIpAdress
            // 
            this.txtReceiveIpAdress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceiveIpAdress.Location = new System.Drawing.Point(9, 92);
            this.txtReceiveIpAdress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReceiveIpAdress.Name = "txtReceiveIpAdress";
            this.txtReceiveIpAdress.Size = new System.Drawing.Size(256, 22);
            this.txtReceiveIpAdress.TabIndex = 24;
            this.txtReceiveIpAdress.Text = "0.0.0.0";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaveLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaveLocation.Location = new System.Drawing.Point(9, 30);
            this.txtSaveLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(256, 22);
            this.txtSaveLocation.TabIndex = 20;
            this.txtSaveLocation.Click += new System.EventHandler(this.BtnSelectSaveLocation_Click);
            // 
            // labelReceiverPort
            // 
            this.labelReceiverPort.AutoSize = true;
            this.labelReceiverPort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReceiverPort.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelReceiverPort.Location = new System.Drawing.Point(271, 74);
            this.labelReceiverPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceiverPort.Name = "labelReceiverPort";
            this.labelReceiverPort.Size = new System.Drawing.Size(34, 17);
            this.labelReceiverPort.TabIndex = 23;
            this.labelReceiverPort.Text = "Port";
            // 
            // labelReceiverIPAdress
            // 
            this.labelReceiverIPAdress.AutoSize = true;
            this.labelReceiverIPAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReceiverIPAdress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelReceiverIPAdress.Location = new System.Drawing.Point(6, 74);
            this.labelReceiverIPAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceiverIPAdress.Name = "labelReceiverIPAdress";
            this.labelReceiverIPAdress.Size = new System.Drawing.Size(20, 17);
            this.labelReceiverIPAdress.TabIndex = 22;
            this.labelReceiverIPAdress.Text = "IP";
            // 
            // labelSaveLocation
            // 
            this.labelSaveLocation.AutoSize = true;
            this.labelSaveLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaveLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSaveLocation.Location = new System.Drawing.Point(6, 11);
            this.labelSaveLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaveLocation.Name = "labelSaveLocation";
            this.labelSaveLocation.Size = new System.Drawing.Size(91, 17);
            this.labelSaveLocation.TabIndex = 21;
            this.labelSaveLocation.Text = "Save Location";
            this.labelSaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectSaveLocation
            // 
            this.btnSelectSaveLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectSaveLocation.Location = new System.Drawing.Point(274, 25);
            this.btnSelectSaveLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectSaveLocation.Name = "btnSelectSaveLocation";
            this.btnSelectSaveLocation.Size = new System.Drawing.Size(135, 28);
            this.btnSelectSaveLocation.TabIndex = 19;
            this.btnSelectSaveLocation.Text = "Select...";
            this.btnSelectSaveLocation.UseVisualStyleBackColor = true;
            this.btnSelectSaveLocation.Click += new System.EventHandler(this.BtnSelectSaveLocation_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.BtnSendFile);
            this.tabPage1.Controls.Add(this.txtSendPort);
            this.tabPage1.Controls.Add(this.txtSendIpAdress);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 433);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Send Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnSendRiskyJson);
            this.groupBox2.Controls.Add(this.SendPort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSendIp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 208);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "위험도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 5;
            // 
            // BtnSendRiskyJson
            // 
            this.BtnSendRiskyJson.Location = new System.Drawing.Point(7, 164);
            this.BtnSendRiskyJson.Name = "BtnSendRiskyJson";
            this.BtnSendRiskyJson.Size = new System.Drawing.Size(387, 23);
            this.BtnSendRiskyJson.TabIndex = 4;
            this.BtnSendRiskyJson.Text = "송신";
            this.BtnSendRiskyJson.UseVisualStyleBackColor = true;
            this.BtnSendRiskyJson.Click += new System.EventHandler(this.BtnSendRiskyJson_Click);
            // 
            // SendPort
            // 
            this.SendPort.Location = new System.Drawing.Point(115, 70);
            this.SendPort.Name = "SendPort";
            this.SendPort.Size = new System.Drawing.Size(100, 25);
            this.SendPort.TabIndex = 3;
            this.SendPort.Text = "26000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port";
            // 
            // txtSendIp
            // 
            this.txtSendIp.Location = new System.Drawing.Point(115, 31);
            this.txtSendIp.Name = "txtSendIp";
            this.txtSendIp.Size = new System.Drawing.Size(213, 25);
            this.txtSendIp.TabIndex = 1;
            this.txtSendIp.Text = "127.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "IP";
            // 
            // BtnSendFile
            // 
            this.BtnSendFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSendFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSendFile.Location = new System.Drawing.Point(9, 138);
            this.BtnSendFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSendFile.Name = "BtnSendFile";
            this.BtnSendFile.Size = new System.Drawing.Size(400, 42);
            this.BtnSendFile.TabIndex = 38;
            this.BtnSendFile.Text = "Send File";
            this.BtnSendFile.UseVisualStyleBackColor = true;
            this.BtnSendFile.Click += new System.EventHandler(this.BtnSendFile_Click);
            // 
            // txtSendPort
            // 
            this.txtSendPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSendPort.Location = new System.Drawing.Point(274, 92);
            this.txtSendPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(135, 22);
            this.txtSendPort.TabIndex = 37;
            this.txtSendPort.Text = "25252";
            // 
            // txtSendIpAdress
            // 
            this.txtSendIpAdress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSendIpAdress.Location = new System.Drawing.Point(9, 92);
            this.txtSendIpAdress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSendIpAdress.Name = "txtSendIpAdress";
            this.txtSendIpAdress.Size = new System.Drawing.Size(256, 22);
            this.txtSendIpAdress.TabIndex = 36;
            this.txtSendIpAdress.Text = "0.0.0.0";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFileName.Location = new System.Drawing.Point(9, 30);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(256, 22);
            this.txtFileName.TabIndex = 32;
            this.txtFileName.Click += new System.EventHandler(this.BtnSelectFileToSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(271, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "IP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(6, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "File to Send";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(274, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 28);
            this.button4.TabIndex = 31;
            this.button4.Text = "Select...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnSelectFileToSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(61, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 39);
            this.groupBox3.TabIndex = 235;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "위험도";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(213, 17);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(33, 21);
            this.radioButton5.TabIndex = 233;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 21);
            this.radioButton1.TabIndex = 228;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(167, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(33, 21);
            this.radioButton4.TabIndex = 232;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 21);
            this.radioButton2.TabIndex = 230;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(123, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(33, 21);
            this.radioButton3.TabIndex = 231;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 463);
            this.Controls.Add(this.MainTabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Server";
            this.MainTabPage.ResumeLayout(false);
            this.TabPageReceiver.ResumeLayout(false);
            this.TabPageReceiver.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStripReceiver.ResumeLayout(false);
            this.statusStripReceiver.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl MainTabPage;
        private TabPage TabPageReceiver;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private StatusStrip statusStripReceiver;
        private ToolStripStatusLabel labelReceivedProgress;
        private ToolStripProgressBar progressBarReceiveFile;
        private Button btnReceiveFile;
        private TextBox txtReceivePort;
        private TextBox txtReceiveIpAdress;
        private TextBox txtSaveLocation;
        private Label labelReceiverPort;
        private Label labelReceiverIPAdress;
        private Label labelSaveLocation;
        private Button btnSelectSaveLocation;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Label label4;
        private Button BtnSendRiskyJson;
        private TextBox SendPort;
        private Label label5;
        private TextBox txtSendIp;
        private Label label6;
        private Button BtnSendFile;
        private TextBox txtSendPort;
        private TextBox txtSendIpAdress;
        private TextBox txtFileName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button4;
        private GroupBox groupBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}

