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
            this.streamPlayerControl1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this._playButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckinStatus = new System.Windows.Forms.Label();
            this.lblTime0 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxEmployee = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // streamPlayerControl1
            // 
            this.streamPlayerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamPlayerControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.streamPlayerControl1.Location = new System.Drawing.Point(13, 44);
            this.streamPlayerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.streamPlayerControl1.Name = "streamPlayerControl1";
            this.streamPlayerControl1.Size = new System.Drawing.Size(599, 1336);
            this.streamPlayerControl1.TabIndex = 0;
            this.streamPlayerControl1.StreamStarted += new System.EventHandler(this.HandleStreamStartedEvent);
            this.streamPlayerControl1.StreamStopped += new System.EventHandler(this.HandleStreamStoppedEvent);
            this.streamPlayerControl1.StreamFailed += new System.EventHandler<WebEye.Controls.WinForms.StreamPlayerControl.StreamFailedEventArgs>(this.HandleStreamFailedEvent);
            // 
            // _playButton
            // 
            this._playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._playButton.Location = new System.Drawing.Point(13, 1412);
            this._playButton.Margin = new System.Windows.Forms.Padding(4);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(100, 46);
            this._playButton.TabIndex = 2;
            this._playButton.Text = "Play";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._stopButton.Enabled = false;
            this._stopButton.Location = new System.Drawing.Point(121, 1413);
            this._stopButton.Margin = new System.Windows.Forms.Padding(4);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(100, 46);
            this._stopButton.TabIndex = 3;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1493, 40);
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
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(229, 1424);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 619);
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
            this.panel1.Location = new System.Drawing.Point(648, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 1336);
            this.panel1.TabIndex = 10;
            // 
            // lblCheckinStatus
            // 
            this.lblCheckinStatus.AutoSize = true;
            this.lblCheckinStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCheckinStatus.Location = new System.Drawing.Point(226, 1033);
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
            this.lblTime0.Location = new System.Drawing.Point(3, 928);
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
            this.lblTime.Location = new System.Drawing.Point(232, 930);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 44);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "...";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.Red;
            this.txtRole.Location = new System.Drawing.Point(284, 821);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(531, 110);
            this.txtRole.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 821);
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
            this.picBoxEmployee.Location = new System.Drawing.Point(240, 19);
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
            this.label3.Location = new System.Drawing.Point(3, 718);
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
            this.lblName.Location = new System.Drawing.Point(157, 720);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 44);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "...";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(157, 619);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 46);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "...";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(43, 1107);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(599, 171);
            this.txtConsole.TabIndex = 22;
            this.txtConsole.Text = "Thông tin kiểm lỗi:";
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // chkTest
            // 
            this.chkTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTest.AutoSize = true;
            this.chkTest.Location = new System.Drawing.Point(1366, 1424);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(115, 29);
            this.chkTest.TabIndex = 11;
            this.chkTest.Text = "Manual";
            this.chkTest.UseVisualStyleBackColor = true;
            this.chkTest.CheckedChanged += new System.EventHandler(this.chkTest_CheckedChanged);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundImage.Location = new System.Drawing.Point(12, 44);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(600, 1296);
            this.backgroundImage.TabIndex = 12;
            this.backgroundImage.TabStop = false;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 1471);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.chkTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this.streamPlayerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManagement";
            this.Text = "Employee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl1;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
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
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.Label lblCheckinStatus;
        private System.Windows.Forms.RichTextBox txtConsole;
    }
}

