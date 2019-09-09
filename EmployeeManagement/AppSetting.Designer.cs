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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageDir = new System.Windows.Forms.TextBox();
            this.btnImageDirSelect = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCamSelect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddtionalSuffix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxSuffix = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDbStatus = new System.Windows.Forms.Label();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minTimeScan = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.progressbarWorker = new System.ComponentModel.BackgroundWorker();
            this.dbConnectionTester = new System.ComponentModel.BackgroundWorker();
            this.chkConsoleEnable = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeScan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(28, 413);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(495, 97);
            this.txtUrl.TabIndex = 7;
            this.txtUrl.Text = "rtsp://127.0.0.1:554/test";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location to save images:";
            // 
            // txtImageDir
            // 
            this.txtImageDir.Location = new System.Drawing.Point(28, 558);
            this.txtImageDir.Multiline = true;
            this.txtImageDir.Name = "txtImageDir";
            this.txtImageDir.Size = new System.Drawing.Size(366, 41);
            this.txtImageDir.TabIndex = 8;
            this.txtImageDir.Text = "D:\\";
            this.txtImageDir.TextChanged += new System.EventHandler(this.txtImageDir_TextChanged);
            // 
            // btnImageDirSelect
            // 
            this.btnImageDirSelect.Location = new System.Drawing.Point(416, 558);
            this.btnImageDirSelect.Name = "btnImageDirSelect";
            this.btnImageDirSelect.Size = new System.Drawing.Size(107, 41);
            this.btnImageDirSelect.TabIndex = 9;
            this.btnImageDirSelect.Text = "Select...";
            this.btnImageDirSelect.UseVisualStyleBackColor = true;
            this.btnImageDirSelect.Click += new System.EventHandler(this.btnImageDirSelect_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(120, 60);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(274, 31);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCamSelect);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtImageDir);
            this.panel1.Controls.Add(this.btnImageDirSelect);
            this.panel1.Controls.Add(this.txtAddtionalSuffix);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboxSuffix);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPasswd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 629);
            this.panel1.TabIndex = 8;
            // 
            // btnCamSelect
            // 
            this.btnCamSelect.Location = new System.Drawing.Point(416, 60);
            this.btnCamSelect.Name = "btnCamSelect";
            this.btnCamSelect.Size = new System.Drawing.Size(107, 87);
            this.btnCamSelect.TabIndex = 23;
            this.btnCamSelect.Text = "Search";
            this.btnCamSelect.UseVisualStyleBackColor = true;
            this.btnCamSelect.Click += new System.EventHandler(this.btnCamSelect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Camera setting:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "+";
            // 
            // txtAddtionalSuffix
            // 
            this.txtAddtionalSuffix.Location = new System.Drawing.Point(120, 337);
            this.txtAddtionalSuffix.Name = "txtAddtionalSuffix";
            this.txtAddtionalSuffix.Size = new System.Drawing.Size(403, 31);
            this.txtAddtionalSuffix.TabIndex = 6;
            this.txtAddtionalSuffix.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Suffix:";
            // 
            // cboxSuffix
            // 
            this.cboxSuffix.FormattingEnabled = true;
            this.cboxSuffix.Location = new System.Drawing.Point(120, 280);
            this.cboxSuffix.Name = "cboxSuffix";
            this.cboxSuffix.Size = new System.Drawing.Size(403, 33);
            this.cboxSuffix.TabIndex = 5;
            this.cboxSuffix.SelectedIndexChanged += new System.EventHandler(this.cboxSuffix_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Passwd:";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(120, 224);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(403, 31);
            this.txtPasswd.TabIndex = 4;
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(120, 116);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(274, 31);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "554";
            this.txtPort.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(120, 169);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(403, 31);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lblDbStatus);
            this.panel2.Controls.Add(this.btnTestDb);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDbName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDbPasswd);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtDbPort);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtDbUser);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtDbIP);
            this.panel2.Location = new System.Drawing.Point(605, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 416);
            this.panel2.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(361, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 43);
            this.progressBar1.TabIndex = 26;
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.AutoSize = true;
            this.lblDbStatus.Location = new System.Drawing.Point(228, 361);
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.Size = new System.Drawing.Size(73, 25);
            this.lblDbStatus.TabIndex = 24;
            this.lblDbStatus.Text = "Status";
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(28, 352);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(188, 43);
            this.btnTestDb.TabIndex = 15;
            this.btnTestDb.Text = "Test connection";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Database setting:";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(135, 279);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(388, 31);
            this.txtDbName.TabIndex = 14;
            this.txtDbName.Text = "louyco";
            this.txtDbName.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "DB name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Passwd:";
            // 
            // txtDbPasswd
            // 
            this.txtDbPasswd.Location = new System.Drawing.Point(135, 223);
            this.txtDbPasswd.Name = "txtDbPasswd";
            this.txtDbPasswd.Size = new System.Drawing.Size(388, 31);
            this.txtDbPasswd.TabIndex = 13;
            this.txtDbPasswd.Text = "qwer1!2@3#4$";
            this.txtDbPasswd.UseSystemPasswordChar = true;
            this.txtDbPasswd.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Port:";
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(135, 115);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(388, 31);
            this.txtDbPort.TabIndex = 11;
            this.txtDbPort.Text = "3306";
            this.txtDbPort.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 25);
            this.label16.TabIndex = 13;
            this.label16.Text = "User:";
            // 
            // txtDbUser
            // 
            this.txtDbUser.Location = new System.Drawing.Point(135, 168);
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.Size = new System.Drawing.Size(388, 31);
            this.txtDbUser.TabIndex = 12;
            this.txtDbUser.Text = "test";
            this.txtDbUser.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "Server:";
            // 
            // txtDbIP
            // 
            this.txtDbIP.Location = new System.Drawing.Point(135, 62);
            this.txtDbIP.Name = "txtDbIP";
            this.txtDbIP.Size = new System.Drawing.Size(388, 31);
            this.txtDbIP.TabIndex = 10;
            this.txtDbIP.Text = "192.168.1.84";
            this.txtDbIP.TextChanged += new System.EventHandler(this.txtDbIP_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(543, 685);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 53);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkDisplayTime
            // 
            this.chkDisplayTime.AutoSize = true;
            this.chkDisplayTime.Location = new System.Drawing.Point(23, 51);
            this.chkDisplayTime.Name = "chkDisplayTime";
            this.chkDisplayTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDisplayTime.Size = new System.Drawing.Size(167, 29);
            this.chkDisplayTime.TabIndex = 24;
            this.chkDisplayTime.Text = ":Display time";
            this.chkDisplayTime.UseVisualStyleBackColor = true;
            this.chkDisplayTime.CheckStateChanged += new System.EventHandler(this.chkDisplayTime_CheckStateChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkConsoleEnable);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.minTimeScan);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.chkDisplayTime);
            this.panel3.Location = new System.Drawing.Point(605, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 183);
            this.panel3.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(479, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 25);
            this.label18.TabIndex = 28;
            this.label18.Text = "second";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(307, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Minumum time between scans:";
            // 
            // minTimeScan
            // 
            this.minTimeScan.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minTimeScan.Location = new System.Drawing.Point(341, 124);
            this.minTimeScan.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.minTimeScan.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.minTimeScan.Name = "minTimeScan";
            this.minTimeScan.Size = new System.Drawing.Size(132, 31);
            this.minTimeScan.TabIndex = 26;
            this.minTimeScan.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Other setting:";
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
            // chkConsoleEnable
            // 
            this.chkConsoleEnable.AutoSize = true;
            this.chkConsoleEnable.Location = new System.Drawing.Point(306, 51);
            this.chkConsoleEnable.Name = "chkConsoleEnable";
            this.chkConsoleEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkConsoleEnable.Size = new System.Drawing.Size(162, 29);
            this.chkConsoleEnable.TabIndex = 29;
            this.chkConsoleEnable.Text = ":Check error";
            this.chkConsoleEnable.UseVisualStyleBackColor = true;
            // 
            // AppSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 774);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minTimeScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImageDir;
        private System.Windows.Forms.Button btnImageDirSelect;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddtionalSuffix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.ComboBox cboxSuffix;
        private System.Windows.Forms.Button btnCamSelect;
        private System.Windows.Forms.CheckBox chkDisplayTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker progressbarWorker;
        private System.ComponentModel.BackgroundWorker dbConnectionTester;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown minTimeScan;
        private System.Windows.Forms.CheckBox chkConsoleEnable;
    }
}