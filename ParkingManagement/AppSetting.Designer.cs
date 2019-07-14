namespace EmployeeManagementApplicationSetting
{
    partial class AppSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSetting));
            this.txtUrlFront = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageDir = new System.Windows.Forms.TextBox();
            this.btnImageDirSelect = new System.Windows.Forms.Button();
            this.txtIpFront = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFrontCamSelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddtionalSuffixFront = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxSuffixFront = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswdFront = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortFront = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserFront = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDbStatus = new System.Windows.Forms.Label();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDbPasswd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDbUser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDbIP = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkDisplayTime = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.screenTimeout = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minTimeScan = new System.Windows.Forms.NumericUpDown();
            this.progressbarWorker = new System.ComponentModel.BackgroundWorker();
            this.dbConnectionTester = new System.ComponentModel.BackgroundWorker();
            this.btnRearCamSelect = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAddtionalSuffixRear = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cboxSuffixRear = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPasswdRear = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPortRear = new System.Windows.Forms.TextBox();
            this.txtUrlRear = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtUserRear = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtIpRear = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.screenTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeScan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrlFront
            // 
            this.txtUrlFront.Location = new System.Drawing.Point(13, 400);
            this.txtUrlFront.Multiline = true;
            this.txtUrlFront.Name = "txtUrlFront";
            this.txtUrlFront.Size = new System.Drawing.Size(367, 97);
            this.txtUrlFront.TabIndex = 7;
            this.txtUrlFront.Text = "rtsp://127.0.0.1:554/test";
            this.txtUrlFront.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location to save images:";
            // 
            // txtImageDir
            // 
            this.txtImageDir.Location = new System.Drawing.Point(27, 579);
            this.txtImageDir.Multiline = true;
            this.txtImageDir.Name = "txtImageDir";
            this.txtImageDir.Size = new System.Drawing.Size(701, 41);
            this.txtImageDir.TabIndex = 8;
            this.txtImageDir.Text = "D:\\";
            this.txtImageDir.TextChanged += new System.EventHandler(this.txtImageDir_TextChanged);
            // 
            // btnImageDirSelect
            // 
            this.btnImageDirSelect.Location = new System.Drawing.Point(734, 579);
            this.btnImageDirSelect.Name = "btnImageDirSelect";
            this.btnImageDirSelect.Size = new System.Drawing.Size(107, 41);
            this.btnImageDirSelect.TabIndex = 9;
            this.btnImageDirSelect.Text = "Select...";
            this.btnImageDirSelect.UseVisualStyleBackColor = true;
            this.btnImageDirSelect.Click += new System.EventHandler(this.btnImageDirSelect_Click);
            // 
            // txtIpFront
            // 
            this.txtIpFront.Location = new System.Drawing.Point(86, 47);
            this.txtIpFront.Name = "txtIpFront";
            this.txtIpFront.Size = new System.Drawing.Size(173, 31);
            this.txtIpFront.TabIndex = 1;
            this.txtIpFront.Text = "127.0.0.1";
            this.txtIpFront.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP:";
            // 
            // btnFrontCamSelect
            // 
            this.btnFrontCamSelect.Location = new System.Drawing.Point(273, 47);
            this.btnFrontCamSelect.Name = "btnFrontCamSelect";
            this.btnFrontCamSelect.Size = new System.Drawing.Size(107, 87);
            this.btnFrontCamSelect.TabIndex = 23;
            this.btnFrontCamSelect.Text = "Search";
            this.btnFrontCamSelect.UseVisualStyleBackColor = true;
            this.btnFrontCamSelect.Click += new System.EventHandler(this.btnFrontCamSelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "+";
            // 
            // txtAddtionalSuffixFront
            // 
            this.txtAddtionalSuffixFront.Location = new System.Drawing.Point(86, 324);
            this.txtAddtionalSuffixFront.Name = "txtAddtionalSuffixFront";
            this.txtAddtionalSuffixFront.Size = new System.Drawing.Size(294, 31);
            this.txtAddtionalSuffixFront.TabIndex = 6;
            this.txtAddtionalSuffixFront.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Suffix:";
            // 
            // cboxSuffixFront
            // 
            this.cboxSuffixFront.FormattingEnabled = true;
            this.cboxSuffixFront.Location = new System.Drawing.Point(86, 267);
            this.cboxSuffixFront.Name = "cboxSuffixFront";
            this.cboxSuffixFront.Size = new System.Drawing.Size(294, 33);
            this.cboxSuffixFront.TabIndex = 5;
            this.cboxSuffixFront.SelectedIndexChanged += new System.EventHandler(this.cboxSuffix_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pass:";
            // 
            // txtPasswdFront
            // 
            this.txtPasswdFront.Location = new System.Drawing.Point(86, 211);
            this.txtPasswdFront.Name = "txtPasswdFront";
            this.txtPasswdFront.Size = new System.Drawing.Size(173, 31);
            this.txtPasswdFront.TabIndex = 4;
            this.txtPasswdFront.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port:";
            // 
            // txtPortFront
            // 
            this.txtPortFront.Location = new System.Drawing.Point(86, 103);
            this.txtPortFront.Name = "txtPortFront";
            this.txtPortFront.Size = new System.Drawing.Size(173, 31);
            this.txtPortFront.TabIndex = 2;
            this.txtPortFront.Text = "554";
            this.txtPortFront.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "User:";
            // 
            // txtUserFront
            // 
            this.txtUserFront.Location = new System.Drawing.Point(86, 156);
            this.txtUserFront.Name = "txtUserFront";
            this.txtUserFront.Size = new System.Drawing.Size(173, 31);
            this.txtUserFront.TabIndex = 3;
            this.txtUserFront.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(330, 337);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 43);
            this.progressBar1.TabIndex = 26;
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.AutoSize = true;
            this.lblDbStatus.Location = new System.Drawing.Point(221, 346);
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.Size = new System.Drawing.Size(73, 25);
            this.lblDbStatus.TabIndex = 24;
            this.lblDbStatus.Text = "Status";
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(21, 337);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(188, 43);
            this.btnTestDb.TabIndex = 15;
            this.btnTestDb.Text = "Test connection";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(128, 264);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(314, 31);
            this.txtDbName.TabIndex = 14;
            this.txtDbName.Text = "louyco";
            this.txtDbName.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "DB name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Passwd:";
            // 
            // txtDbPasswd
            // 
            this.txtDbPasswd.Location = new System.Drawing.Point(128, 208);
            this.txtDbPasswd.Name = "txtDbPasswd";
            this.txtDbPasswd.Size = new System.Drawing.Size(314, 31);
            this.txtDbPasswd.TabIndex = 13;
            this.txtDbPasswd.Text = "3V5wn0Kv9RRc8gQA";
            this.txtDbPasswd.UseSystemPasswordChar = true;
            this.txtDbPasswd.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Port:";
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(128, 97);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(314, 31);
            this.txtDbPort.TabIndex = 11;
            this.txtDbPort.Text = "3306";
            this.txtDbPort.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 25);
            this.label16.TabIndex = 13;
            this.label16.Text = "User:";
            // 
            // txtDbUser
            // 
            this.txtDbUser.Location = new System.Drawing.Point(128, 153);
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.Size = new System.Drawing.Size(314, 31);
            this.txtDbUser.TabIndex = 12;
            this.txtDbUser.Text = "root";
            this.txtDbUser.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "Server:";
            // 
            // txtDbIP
            // 
            this.txtDbIP.Location = new System.Drawing.Point(128, 47);
            this.txtDbIP.Name = "txtDbIP";
            this.txtDbIP.Size = new System.Drawing.Size(314, 31);
            this.txtDbIP.TabIndex = 10;
            this.txtDbIP.Text = "127.0.0.1";
            this.txtDbIP.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(646, 655);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(4);
            this.btnOK.Size = new System.Drawing.Size(115, 63);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkDisplayTime
            // 
            this.chkDisplayTime.AutoSize = true;
            this.chkDisplayTime.Location = new System.Drawing.Point(12, 42);
            this.chkDisplayTime.Name = "chkDisplayTime";
            this.chkDisplayTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDisplayTime.Size = new System.Drawing.Size(167, 29);
            this.chkDisplayTime.TabIndex = 24;
            this.chkDisplayTime.Text = ":Display time";
            this.chkDisplayTime.UseVisualStyleBackColor = true;
            this.chkDisplayTime.CheckStateChanged += new System.EventHandler(this.chkDisplayTime_CheckStateChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(377, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 25);
            this.label20.TabIndex = 31;
            this.label20.Text = "second";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(99, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(162, 25);
            this.label28.TabIndex = 30;
            this.label28.Text = "Screen timeout:";
            // 
            // screenTimeout
            // 
            this.screenTimeout.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.screenTimeout.Location = new System.Drawing.Point(266, 139);
            this.screenTimeout.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.screenTimeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.screenTimeout.Name = "screenTimeout";
            this.screenTimeout.Size = new System.Drawing.Size(106, 31);
            this.screenTimeout.TabIndex = 29;
            this.screenTimeout.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(377, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 25);
            this.label18.TabIndex = 28;
            this.label18.Text = "second";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Min time between scans:";
            // 
            // minTimeScan
            // 
            this.minTimeScan.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minTimeScan.Location = new System.Drawing.Point(266, 84);
            this.minTimeScan.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.minTimeScan.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minTimeScan.Name = "minTimeScan";
            this.minTimeScan.Size = new System.Drawing.Size(106, 31);
            this.minTimeScan.TabIndex = 26;
            this.minTimeScan.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // progressbarWorker
            // 
            this.progressbarWorker.WorkerSupportsCancellation = true;
            this.progressbarWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressbarWorker_DoWork);
            this.progressbarWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressbarWorker_ProgressChanged);
            // 
            // dbConnectionTester
            // 
            this.dbConnectionTester.WorkerSupportsCancellation = true;
            this.dbConnectionTester.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dbConnectionTester_DoWork);
            this.dbConnectionTester.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dbConnectionTester_RunWorkerCompleted);
            // 
            // btnRearCamSelect
            // 
            this.btnRearCamSelect.Location = new System.Drawing.Point(281, 47);
            this.btnRearCamSelect.Name = "btnRearCamSelect";
            this.btnRearCamSelect.Size = new System.Drawing.Size(107, 87);
            this.btnRearCamSelect.TabIndex = 23;
            this.btnRearCamSelect.Text = "Search";
            this.btnRearCamSelect.UseVisualStyleBackColor = true;
            this.btnRearCamSelect.Click += new System.EventHandler(this.btnRearCamSelect_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(67, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 25);
            this.label21.TabIndex = 21;
            this.label21.Text = "+";
            // 
            // txtAddtionalSuffixRear
            // 
            this.txtAddtionalSuffixRear.Location = new System.Drawing.Point(94, 324);
            this.txtAddtionalSuffixRear.Name = "txtAddtionalSuffixRear";
            this.txtAddtionalSuffixRear.Size = new System.Drawing.Size(294, 31);
            this.txtAddtionalSuffixRear.TabIndex = 6;
            this.txtAddtionalSuffixRear.TextChanged += new System.EventHandler(this.txtIPRear_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 270);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 25);
            this.label22.TabIndex = 18;
            this.label22.Text = "Suffix:";
            // 
            // cboxSuffixRear
            // 
            this.cboxSuffixRear.FormattingEnabled = true;
            this.cboxSuffixRear.Location = new System.Drawing.Point(94, 267);
            this.cboxSuffixRear.Name = "cboxSuffixRear";
            this.cboxSuffixRear.Size = new System.Drawing.Size(294, 33);
            this.cboxSuffixRear.TabIndex = 5;
            this.cboxSuffixRear.SelectedIndexChanged += new System.EventHandler(this.cboxSuffixRear_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 25);
            this.label23.TabIndex = 17;
            this.label23.Text = "Pass:";
            // 
            // txtPasswdRear
            // 
            this.txtPasswdRear.Location = new System.Drawing.Point(94, 211);
            this.txtPasswdRear.Name = "txtPasswdRear";
            this.txtPasswdRear.Size = new System.Drawing.Size(173, 31);
            this.txtPasswdRear.TabIndex = 4;
            this.txtPasswdRear.TextChanged += new System.EventHandler(this.txtIPRear_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 368);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 25);
            this.label24.TabIndex = 2;
            this.label24.Text = "Preview:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 25);
            this.label25.TabIndex = 15;
            this.label25.Text = "Port:";
            // 
            // txtPortRear
            // 
            this.txtPortRear.Location = new System.Drawing.Point(94, 103);
            this.txtPortRear.Name = "txtPortRear";
            this.txtPortRear.Size = new System.Drawing.Size(173, 31);
            this.txtPortRear.TabIndex = 2;
            this.txtPortRear.Text = "554";
            this.txtPortRear.TextChanged += new System.EventHandler(this.txtIPRear_TextChanged);
            // 
            // txtUrlRear
            // 
            this.txtUrlRear.Location = new System.Drawing.Point(21, 400);
            this.txtUrlRear.Multiline = true;
            this.txtUrlRear.Name = "txtUrlRear";
            this.txtUrlRear.Size = new System.Drawing.Size(367, 97);
            this.txtUrlRear.TabIndex = 7;
            this.txtUrlRear.Text = "rtsp://127.0.0.1:554/test";
            this.txtUrlRear.TextChanged += new System.EventHandler(this.txtUrlRear_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 159);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 25);
            this.label26.TabIndex = 13;
            this.label26.Text = "User:";
            // 
            // txtUserRear
            // 
            this.txtUserRear.Location = new System.Drawing.Point(94, 156);
            this.txtUserRear.Name = "txtUserRear";
            this.txtUserRear.Size = new System.Drawing.Size(173, 31);
            this.txtUserRear.TabIndex = 3;
            this.txtUserRear.TextChanged += new System.EventHandler(this.txtIPRear_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 25);
            this.label27.TabIndex = 7;
            this.label27.Text = "IP:";
            // 
            // txtIpRear
            // 
            this.txtIpRear.Location = new System.Drawing.Point(94, 47);
            this.txtIpRear.Name = "txtIpRear";
            this.txtIpRear.Size = new System.Drawing.Size(173, 31);
            this.txtIpRear.TabIndex = 1;
            this.txtIpRear.Text = "127.0.0.1";
            this.txtIpRear.TextChanged += new System.EventHandler(this.txtIPRear_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFrontCamSelect);
            this.groupBox1.Controls.Add(this.txtAddtionalSuffixFront);
            this.groupBox1.Controls.Add(this.txtIpFront);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserFront);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxSuffixFront);
            this.groupBox1.Controls.Add(this.txtUrlFront);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPortFront);
            this.groupBox1.Controls.Add(this.txtPasswdFront);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 518);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front camera setting:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRearCamSelect);
            this.groupBox2.Controls.Add(this.cboxSuffixRear);
            this.groupBox2.Controls.Add(this.txtIpRear);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtAddtionalSuffixRear);
            this.groupBox2.Controls.Add(this.txtUserRear);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtUrlRear);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtPortRear);
            this.groupBox2.Controls.Add(this.txtPasswdRear);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 518);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rear camera setting:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.lblDbStatus);
            this.groupBox3.Controls.Add(this.txtDbIP);
            this.groupBox3.Controls.Add(this.btnTestDb);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDbUser);
            this.groupBox3.Controls.Add(this.txtDbName);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDbPort);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtDbPasswd);
            this.groupBox3.Location = new System.Drawing.Point(860, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 404);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database setting:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.minTimeScan);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.chkDisplayTime);
            this.groupBox4.Controls.Add(this.screenTimeout);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(860, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 197);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other setting:";
            // 
            // AppSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtImageDir);
            this.Controls.Add(this.btnImageDirSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppSetting";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.screenTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeScan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrlFront;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImageDir;
        private System.Windows.Forms.Button btnImageDirSelect;
        private System.Windows.Forms.TextBox txtIpFront;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswdFront;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortFront;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserFront;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddtionalSuffixFront;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDbPasswd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDbUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDbIP;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDbStatus;
        private System.Windows.Forms.Button btnTestDb;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboxSuffixFront;
        private System.Windows.Forms.Button btnFrontCamSelect;
        private System.Windows.Forms.CheckBox chkDisplayTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker progressbarWorker;
        private System.ComponentModel.BackgroundWorker dbConnectionTester;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown minTimeScan;
        private System.Windows.Forms.Button btnRearCamSelect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAddtionalSuffixRear;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboxSuffixRear;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPasswdRear;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPortRear;
        private System.Windows.Forms.TextBox txtUrlRear;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtUserRear;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtIpRear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown screenTimeout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}