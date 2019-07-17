namespace EmployeeManagement
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.frontCameraStream = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this._playButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesMotobikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFrontCamStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMotorNum = new System.Windows.Forms.Label();
            this.lblCheckinStatus = new System.Windows.Forms.Label();
            this.lblTime0 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxEmployee = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.frontImageSaved = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rearImageCaptured = new System.Windows.Forms.PictureBox();
            this.frontImageCaptured = new System.Windows.Forms.PictureBox();
            this.rearCameraStream = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.rearImageSaved = new System.Windows.Forms.PictureBox();
            this.lblRearCamStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImageSaved)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rearImageCaptured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImageCaptured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rearImageSaved)).BeginInit();
            this.SuspendLayout();
            // 
            // frontCameraStream
            // 
            this.frontCameraStream.BackColor = System.Drawing.Color.Gainsboro;
            this.frontCameraStream.Location = new System.Drawing.Point(4, 4);
            this.frontCameraStream.Margin = new System.Windows.Forms.Padding(4);
            this.frontCameraStream.Name = "frontCameraStream";
            this.frontCameraStream.Size = new System.Drawing.Size(600, 600);
            this.frontCameraStream.TabIndex = 0;
            this.frontCameraStream.StreamStarted += new System.EventHandler(this.FrontCamHandleStreamStartedEvent);
            this.frontCameraStream.StreamStopped += new System.EventHandler(this.FrontCamHandleStreamStoppedEvent);
            this.frontCameraStream.StreamFailed += new System.EventHandler<WebEye.Controls.WinForms.StreamPlayerControl.StreamFailedEventArgs>(this.FrontCamHandleStreamFailedEvent);
            // 
            // _playButton
            // 
            this._playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._playButton.Location = new System.Drawing.Point(13, 1324);
            this._playButton.Margin = new System.Windows.Forms.Padding(4);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(100, 43);
            this._playButton.TabIndex = 2;
            this._playButton.Text = "Play";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._stopButton.Enabled = false;
            this._stopButton.Location = new System.Drawing.Point(121, 1324);
            this._stopButton.Margin = new System.Windows.Forms.Padding(4);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(100, 44);
            this._stopButton.TabIndex = 3;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this._stopButton.Enter += new System.EventHandler(this._stopButton_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenu,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2734, 40);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingMenu
            // 
            this.settingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem});
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(103, 36);
            this.settingMenu.Text = "Setting";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.cameraToolStripMenuItem.Text = "App Setting";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesMotobikeToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // employeesMotobikeToolStripMenuItem
            // 
            this.employeesMotobikeToolStripMenuItem.Name = "employeesMotobikeToolStripMenuItem";
            this.employeesMotobikeToolStripMenuItem.Size = new System.Drawing.Size(353, 38);
            this.employeesMotobikeToolStripMenuItem.Text = "Employees motorbike ";
            this.employeesMotobikeToolStripMenuItem.Click += new System.EventHandler(this.employeesMotobikeToolStripMenuItem_Click);
            // 
            // lblFrontCamStatus
            // 
            this.lblFrontCamStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFrontCamStatus.AutoSize = true;
            this.lblFrontCamStatus.Location = new System.Drawing.Point(234, 1321);
            this.lblFrontCamStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblFrontCamStatus.Name = "lblFrontCamStatus";
            this.lblFrontCamStatus.Size = new System.Drawing.Size(73, 25);
            this.lblFrontCamStatus.TabIndex = 1;
            this.lblFrontCamStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMotorNum);
            this.panel1.Controls.Add(this.lblCheckinStatus);
            this.panel1.Controls.Add(this.lblTime0);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picBoxEmployee);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1889, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 1263);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 760);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 46);
            this.label4.TabIndex = 23;
            this.label4.Text = "Biển số:";
            this.label4.Click += new System.EventHandler(this.LabelMotorNumber_Click);
            // 
            // lblMotorNum
            // 
            this.lblMotorNum.AutoSize = true;
            this.lblMotorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorNum.ForeColor = System.Drawing.Color.Red;
            this.lblMotorNum.Location = new System.Drawing.Point(182, 762);
            this.lblMotorNum.Name = "lblMotorNum";
            this.lblMotorNum.Size = new System.Drawing.Size(56, 44);
            this.lblMotorNum.TabIndex = 22;
            this.lblMotorNum.Text = "...";
            this.lblMotorNum.Click += new System.EventHandler(this.LabelMotorNumber_Click);
            // 
            // lblCheckinStatus
            // 
            this.lblCheckinStatus.AutoSize = true;
            this.lblCheckinStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCheckinStatus.Location = new System.Drawing.Point(226, 1013);
            this.lblCheckinStatus.Name = "lblCheckinStatus";
            this.lblCheckinStatus.Size = new System.Drawing.Size(89, 73);
            this.lblCheckinStatus.TabIndex = 21;
            this.lblCheckinStatus.Text = "...";
            // 
            // lblTime0
            // 
            this.lblTime0.AutoSize = true;
            this.lblTime0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime0.ForeColor = System.Drawing.Color.Red;
            this.lblTime0.Location = new System.Drawing.Point(3, 934);
            this.lblTime0.Name = "lblTime0";
            this.lblTime0.Size = new System.Drawing.Size(205, 46);
            this.lblTime0.TabIndex = 20;
            this.lblTime0.Text = "Thời gian:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(232, 936);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 44);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "...";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.Red;
            this.txtRole.Location = new System.Drawing.Point(284, 852);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(531, 87);
            this.txtRole.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 852);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tổ/Bộ Phận:";
            // 
            // picBoxEmployee
            // 
            this.picBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxEmployee.Location = new System.Drawing.Point(240, 11);
            this.picBoxEmployee.Name = "picBoxEmployee";
            this.picBoxEmployee.Size = new System.Drawing.Size(381, 549);
            this.picBoxEmployee.TabIndex = 15;
            this.picBoxEmployee.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(157, 681);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 44);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "...";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(157, 599);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 46);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "...";
            // 
            // chkTest
            // 
            this.chkTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTest.AutoSize = true;
            this.chkTest.Location = new System.Drawing.Point(2607, 1336);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(115, 29);
            this.chkTest.TabIndex = 11;
            this.chkTest.Text = "Manual";
            this.chkTest.UseVisualStyleBackColor = true;
            this.chkTest.CheckedChanged += new System.EventHandler(this.chkTest_CheckedChanged);
            // 
            // frontImageSaved
            // 
            this.frontImageSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frontImageSaved.Location = new System.Drawing.Point(1245, 4);
            this.frontImageSaved.Name = "frontImageSaved";
            this.frontImageSaved.Size = new System.Drawing.Size(600, 600);
            this.frontImageSaved.TabIndex = 12;
            this.frontImageSaved.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rearImageCaptured);
            this.panel2.Controls.Add(this.frontImageCaptured);
            this.panel2.Controls.Add(this.rearCameraStream);
            this.panel2.Controls.Add(this.rearImageSaved);
            this.panel2.Controls.Add(this.frontCameraStream);
            this.panel2.Controls.Add(this.frontImageSaved);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1871, 1263);
            this.panel2.TabIndex = 13;
            // 
            // rearImageCaptured
            // 
            this.rearImageCaptured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rearImageCaptured.Location = new System.Drawing.Point(624, 636);
            this.rearImageCaptured.Name = "rearImageCaptured";
            this.rearImageCaptured.Size = new System.Drawing.Size(600, 600);
            this.rearImageCaptured.TabIndex = 16;
            this.rearImageCaptured.TabStop = false;
            // 
            // frontImageCaptured
            // 
            this.frontImageCaptured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frontImageCaptured.Location = new System.Drawing.Point(624, 4);
            this.frontImageCaptured.Name = "frontImageCaptured";
            this.frontImageCaptured.Size = new System.Drawing.Size(600, 600);
            this.frontImageCaptured.TabIndex = 15;
            this.frontImageCaptured.TabStop = false;
            // 
            // rearCameraStream
            // 
            this.rearCameraStream.BackColor = System.Drawing.Color.Gainsboro;
            this.rearCameraStream.Location = new System.Drawing.Point(4, 636);
            this.rearCameraStream.Margin = new System.Windows.Forms.Padding(4);
            this.rearCameraStream.Name = "rearCameraStream";
            this.rearCameraStream.Size = new System.Drawing.Size(600, 600);
            this.rearCameraStream.TabIndex = 14;
            this.rearCameraStream.StreamStarted += new System.EventHandler(this.rearCameraStream_StreamStarted);
            this.rearCameraStream.StreamStopped += new System.EventHandler(this.rearCameraStream_StreamStopped);
            this.rearCameraStream.StreamFailed += new System.EventHandler<WebEye.Controls.WinForms.StreamPlayerControl.StreamFailedEventArgs>(this.rearCameraStream_StreamFailed);
            // 
            // rearImageSaved
            // 
            this.rearImageSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rearImageSaved.Location = new System.Drawing.Point(1245, 636);
            this.rearImageSaved.Name = "rearImageSaved";
            this.rearImageSaved.Size = new System.Drawing.Size(600, 600);
            this.rearImageSaved.TabIndex = 13;
            this.rearImageSaved.TabStop = false;
            // 
            // lblRearCamStatus
            // 
            this.lblRearCamStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRearCamStatus.AutoSize = true;
            this.lblRearCamStatus.Location = new System.Drawing.Point(234, 1346);
            this.lblRearCamStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblRearCamStatus.Name = "lblRearCamStatus";
            this.lblRearCamStatus.Size = new System.Drawing.Size(73, 25);
            this.lblRearCamStatus.TabIndex = 14;
            this.lblRearCamStatus.Text = "Status";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2734, 1378);
            this.Controls.Add(this.lblRearCamStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFrontCamStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManagement";
            this.Text = "Parking Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.EmployeeManagement_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.EmployeeManagement_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImageSaved)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rearImageCaptured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImageCaptured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rearImageSaved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl frontCameraStream;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.Label lblFrontCamStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picBoxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblTime0;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox frontImageSaved;
        private System.Windows.Forms.Label lblCheckinStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox rearImageSaved;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl rearCameraStream;
        private System.Windows.Forms.Label lblRearCamStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMotorNum;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesMotobikeToolStripMenuItem;
        private System.Windows.Forms.PictureBox frontImageCaptured;
        private System.Windows.Forms.PictureBox rearImageCaptured;
    }
}

