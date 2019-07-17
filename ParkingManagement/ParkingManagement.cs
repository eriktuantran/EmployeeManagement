using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyDictionary = System.Collections.Generic.Dictionary<string, string>;

namespace EmployeeManagement
{
    using EmployeeManagementApplicationSetting;
    using ParkingManagement;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Timers;
    using WebEye.Controls.WinForms.StreamPlayerControl;

    public partial class EmployeeManagement : Form
    {
        private string imageDir = "";
        private string connectionString = "";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        //Entering the ID manual
        private bool manualMode = false;

        private string frontCameraAddress = "";
        private string rearCameraAddress = "";

        private bool isDisplayTime = false;


        string backgroundImageDir = Directory.GetCurrentDirectory() + "\\background.jpg";
        Bitmap backImage;


        //Prevent double scan in the very short time
        private Dictionary<string, DateTime> scaningState;
        private double minTimeBetweenScanSteps = 3600; //second

        private double screenTimeoutValue = 60;

        // Enabled in Play button, auto retry in connection failed
        private bool cameraStatus = true;

        private static System.Timers.Timer backgroundTimer;

        public EmployeeManagement()
        {
            InitializeComponent();

            //Prevent double scan in the very short time
            scaningState = new Dictionary<string, DateTime>();

            // Read config from file
            Configuration config = new Configuration();
            MyDictionary dictRead = config.loadDictionaryFromFile();

            // Update camera URL, SQL connection string,...
            populateFormIntialValue(dictRead);

            // Config file not exist
            if (frontCameraAddress == "" || rearCameraAddress == "" || connectionString == "" || imageDir == "")
            {
                getValueFromSettingForm();
            }

            // Display time
            lblTime0.Visible = lblTime.Visible = isDisplayTime;

            // Manual mode
            manualMode = chkTest.Checked;

            //SQL connection
            connection = new MySqlConnection(connectionString);

            //Automatic start camera
            playCamera();

            //Background Image
            frontImageSaved.SizeMode = PictureBoxSizeMode.StretchImage;
            rearImageSaved.SizeMode = PictureBoxSizeMode.StretchImage;
            frontImageCaptured.SizeMode = PictureBoxSizeMode.StretchImage;
            rearImageCaptured.SizeMode = PictureBoxSizeMode.StretchImage;
            //frontImageSaved.Visible = true;
            //try
            //{
            //    backImage = new Bitmap(backgroundImageDir);
            //    frontImageSaved.Image = (Image)backImage;
            //}
            //catch
            //{
            //    Console.WriteLine("Background image not found: " + backgroundImageDir);
            //}

            //Setup background timer
            backgroundTimer = new System.Timers.Timer(screenTimeoutValue*1000);
            backgroundTimer.Elapsed += OnTimedEvent;
            backgroundTimer.AutoReset = false;
        }

        void populateFormIntialValue(MyDictionary dict)
        {
            if (dict.ContainsKey("urlfront") && dict["urlfront"] != "")
            {
                frontCameraAddress = dict["urlfront"];
            }
            if (dict.ContainsKey("urlrear") && dict["urlrear"] != "")
            {
                rearCameraAddress = dict["urlrear"];
            }
            if (dict.ContainsKey("connectstring") && dict["connectstring"] != "")
            {
                connectionString = dict["connectstring"];
            }
            if (dict.ContainsKey("imagedir") && dict["imagedir"] != "")
            {
                imageDir = dict["imagedir"];
            }
            if (dict.ContainsKey("displaytime") && dict["displaytime"] != "")
            {
                isDisplayTime = dict["displaytime"].Contains("rue");
            }
            if (dict.ContainsKey("mintimescan") && dict["mintimescan"] != "")
            {
                minTimeBetweenScanSteps = Int32.Parse(dict["mintimescan"]);
            }
            if (dict.ContainsKey("screentimeout") && dict["screentimeout"] != "")
            {
                screenTimeoutValue = Int32.Parse(dict["screentimeout"]);
            }
        }

        void getValueFromSettingForm()
        {
            var appSetting = new AppSetting();
            appSetting.ShowDialog();

            //Collect Data
            if (appSetting.isOKButtonClicked)
            {
                frontCameraAddress = appSetting.cameraUrlFront;
                rearCameraAddress = appSetting.cameraUrlRear;
                imageDir = appSetting.imageDir;
                connectionString = appSetting.connectionString;
                connection = new MySqlConnection(connectionString);
                isDisplayTime = appSetting.isDisplayTime;
                minTimeBetweenScanSteps = appSetting.minTimeBetweenScanSteps;
                screenTimeoutValue = appSetting.screenTimeoutValue;
                Console.WriteLine("Setting done");
            }
            else
            {
                Console.WriteLine("Setting Terminated");
            }
        }

        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);

            if (!manualMode)
            {
                if (elapsed.TotalMilliseconds > 150)
                    _barcode.Clear();
            }

            if (manualMode && e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (_barcode.Count > 0)
                {
                    _barcode.RemoveAt(_barcode.Count - 1);
                    string msg = new String(_barcode.ToArray());
                    lblId.Text = msg;
                }
                return;
            }

            if (e.KeyChar != 13)
            {
                if (_barcode.Count < 6)
                {
                    _barcode.Add(e.KeyChar);
                }
                _lastKeystroke = DateTime.Now;

                if (manualMode)
                {
                    string msg = new String(_barcode.ToArray());
                    lblId.Text = msg;

                    if (_barcode.Count == 1)
                    {
                        lblName.Text = txtRole.Text = lblTime.Text = lblCheckinStatus.Text = lblMotorNum.Text = "";
                        picBoxEmployee.Image = null;
                    }
                }
                clearImageWindow();
            }
            else if (e.KeyChar == 13 && _barcode.Count > 0) //MAIN EVENT
            {
                string empId = new String(_barcode.ToArray());
                //MessageBox.Show(msg);
                lblId.Text = empId;
                _barcode.Clear();

                // Check if the ID is valid: contains number
                int tmp;
                if (!Int32.TryParse(empId, out tmp))
                {
                    Console.WriteLine("Invalid ID: " + empId);
                    lblId.Text = "";
                    return;
                }

                // Employee exist or not
                if (!isEmployeeExist(empId))
                {
                    lblId.Text = lblName.Text = txtRole.Text = lblTime.Text = lblCheckinStatus.Text = lblMotorNum.Text = "";
                    picBoxEmployee.Image = null;
                    Console.WriteLine("Employee does not exist: " + empId);
                    return;
                }

                // Check recent activities
                if (scaningState.ContainsKey(empId))
                {
                    DateTime last = scaningState[empId];
                    DateTime now = DateTime.Now;
                    double timeDiff = (now - last).TotalSeconds;
                    Console.WriteLine("TimeDiff for " + empId + ": " + timeDiff.ToString());

                    if (timeDiff < minTimeBetweenScanSteps)
                    {
                        int remain = (int)(minTimeBetweenScanSteps - timeDiff);
                        Console.WriteLine("Duplicated activities");
                        lblId.Text = "Đã thực hiện!";
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Remove key from activities");
                        scaningState.Remove(empId);
                    }
                }

                // Save activities timestamp
                scaningState[empId] = DateTime.Now;


                // Actual event to update GUI and DB
                string absFrontImageDir = captureCamera(1);
                string absRearImageDir = captureCamera(2);
                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string frontImageCheckIn = "";
                    string rearImageCheckIn = "";
                    bool rowExist = isParkingRowExist(empId, date, out frontImageCheckIn, out rearImageCheckIn);
                    Console.WriteLine(rowExist);
                    Console.WriteLine(frontImageCheckIn + "_" + rearImageCheckIn);
                    updateTimeInOut(empId, absFrontImageDir, absRearImageDir, rowExist);
                    displayNameAndImage(empId);
                    displayTime();
                    if (!rowExist) //checkin
                    {
                        //displayImageWindow(absFrontImageDir, absRearImageDir);
                        //It has already done at captureCamera 1/2
                    }
                    else //checkout
                    {
                        displayImageWindowStoredInDb(rearImageCheckIn, frontImageCheckIn);
                    }

                    // Timer to clean up screen
                    if (!backgroundTimer.Enabled)
                    {
                        backgroundTimer.Stop();
                    }
                    backgroundTimer.Interval = screenTimeoutValue * 1000;
                    
                    backgroundTimer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection ERROR: " + ex.Message, "Lost database connection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            
            this.Invoke((Action)this.screenSweeper);
        }

        private void screenSweeper()
        {
            clearImageWindow();
            if (!(manualMode && lblId.Text.Length < 6))
            {
                lblId.Text = "";
            }
            lblName.Text = txtRole.Text = lblTime.Text = lblCheckinStatus.Text = lblMotorNum.Text = "";
            picBoxEmployee.Image = null;
        }

        void displayTime()
        {
            DateTime now = DateTime.Now;
            string timeStamp = now.ToString("yyyy-MM-dd HH:mm:ss");
            lblTime.Text = timeStamp;
        }

        void clearImageWindow()
        {
            frontImageSaved.Image = null;
            rearImageSaved.Image = null;
            frontImageCaptured.Image = null;
            rearImageCaptured.Image = null;
        }

        void displayImageWindowStoredInDb(string frontImageCheckIn, string rearImageCheckIn)
        {
            if (frontImageCheckIn != "")
            {
                try
                {
                    var front = new Bitmap(frontImageCheckIn);
                    frontImageSaved.Image = (Image)front;
                }
                catch
                {
                    frontImageSaved.Image = null;
                }
            }
            else
            {
                frontImageSaved.Image = null;
            }
            if (rearImageCheckIn != "")
            {
                try
                {
                    var rear = new Bitmap(rearImageCheckIn);
                    rearImageSaved.Image = (Image)rear;
                }
                catch
                {
                    rearImageSaved.Image = null;
                }
            }
            else
            {
                rearImageSaved.Image = null;
            }
        }
        string captureCamera(int camIndex)
        {
            string now = DateTime.Now.ToString("-yyyy-MM-ddTHH-mm-ss");
            string filename = "";
            try
            {
                switch(camIndex)
                {
                    case 1: //front
                        filename = imageDir + "\\" + "Front-"+lblId.Text + now + ".bmp";
                        Console.WriteLine(filename);
                        var front = frontCameraStream.GetCurrentFrame();
                        try
                        {
                            front.Save(filename);
                            filename = filename.Replace("\\", "\\\\");
                        }
                        catch
                        {
                            Console.WriteLine("Failed to write front image to hard disk");
                            filename = "";
                        }
                        frontImageCaptured.Image = front;
                        return filename;
                        break;
                    case 2: //rear
                        filename = imageDir + "\\" + "Rear-"+lblId.Text + now + ".bmp";
                        Console.WriteLine(filename);
                        var rear = rearCameraStream.GetCurrentFrame();
                        try
                        {
                            rear.Save(filename);
                            filename = filename.Replace("\\", "\\\\");
                        }
                        catch
                        {
                            Console.WriteLine("Failed to write rear image to hard disk");
                            filename = "";
                        }
                        rearImageCaptured.Image = rear;
                        return filename;
                        break;
                    default:
                        break;
                }
                
            }
            catch { }
            return "";
        }

        private void displayNameAndImage(string empId)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select last_name,first_name,bophan_id from employees where emp_no='" + empId + "';";

                    MySqlCommand command = new MySqlCommand(selectCmd, connection);
                    reader = command.ExecuteReader();

                    string name = "";
                    string bo_phan_id = "";
                    string bo_phan = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            name += reader.GetString(0);
                            name += " ";
                            name += reader.GetString(1);
                            try
                            {
                                bo_phan_id = reader.GetString(2);
                            }
                            catch { }
                        }
                    }
                    CloseConnection();
                    lblName.Text = name;

                    // Department
                    this.OpenConnection();
                    selectCmd = "select name from bophan where id='" + bo_phan_id + "';";
                    MySqlCommand command2 = new MySqlCommand(selectCmd, connection);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            bo_phan = reader2.GetString(0);
                        }
                    }
                    txtRole.Text = bo_phan;
                    CloseConnection();

                    // Motorbike number
                    string motorNum = "";
                    this.OpenConnection();
                    selectCmd = "select num from bienso where emp_no='" + empId + "';";
                    MySqlCommand command3 = new MySqlCommand(selectCmd, connection);
                    MySqlDataReader reader3 = command3.ExecuteReader();
                    if (reader3.HasRows)
                    {
                        while (reader3.Read())
                        {
                            if (!reader3.IsDBNull(0))
                            {
                                motorNum = reader3.GetString(0);
                            }
                            
                        }
                    }
                    lblMotorNum.Text = motorNum;
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            if (lblName.Text != "")
            {
                updateEmployeeImage(empId);
            }
            else
            {
                picBoxEmployee.Image = null;
            }

        }

        string employeeImageFileSearchById(string dir, string id)
        {
            string fileName = "";
            try
            {
                foreach (string subDir in Directory.GetDirectories(dir))
                {
                    foreach (string f in Directory.GetFiles(subDir))
                    {
                        if (f.Contains(id))
                        {
                            Console.WriteLine(f);
                            fileName = f;
                            break;
                        }
                    }
                    employeeImageFileSearchById(subDir, id);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fileName;
        }

        private void updateEmployeeImage(string id)
        {
            string baseDir = Directory.GetCurrentDirectory();
            string absImageFile = employeeImageFileSearchById(baseDir, id);
            if(absImageFile == "")
            {
                picBoxEmployee.Image = null;
                return;
            }

            try
            {

                Bitmap image = new Bitmap(absImageFile);
                picBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxEmployee.Image = (Image)image;
            }
            catch
            {
                Console.WriteLine("Image file error");
                picBoxEmployee.Image = null;
            }
        }

        private bool isParkingRowExist(string id, string date, out string frontIn, out string rearIn)
        {
            frontIn = "";
            rearIn = "";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select emp_no,front_in,rear_in from parking where emp_no='" + id+"' and date='" + date + "' and checkout is NULL;";

                    MySqlCommand command = new MySqlCommand(selectCmd, connection);
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                frontIn = reader.GetString(1);
                                rearIn = reader.GetString(2);
                            }
                            catch { }
                        }
                        CloseConnection();
                        return true;
                    }
                    else
                    {
                        CloseConnection();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return false;
        }

        private bool isEmployeeExist(string id)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select emp_no from employees where emp_no='" + id + "';";

                    MySqlCommand command = new MySqlCommand(selectCmd, connection);
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        CloseConnection();
                        return true;
                    }
                    else
                    {
                        CloseConnection();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not connect to database!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseConnection();
            return false;
        }

        private void updateTimeInOut(string id, string absFrontImageDir, string absRearImageDir, bool rowExist)
        {
            DateTime now = DateTime.Now;
            string timeStamp = now.ToString("yyyy-MM-dd HH:mm:ss");
            string date = now.ToString("yyyy-MM-dd");

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                if (rowExist)
                {
                    // Check out
                    cmd.CommandText = "update parking set checkout=CURRENT_TIMESTAMP,";
                    cmd.CommandText += "front_out='" + absFrontImageDir + "',";
                    cmd.CommandText += "rear_out='" + absRearImageDir + "' ";
                    cmd.CommandText += "where emp_no='" + id + "' and date='" + date + "' and checkout is NULL;";
                    lblCheckinStatus.Text = "CẢM ƠN";
                    Console.WriteLine("Line exist: " + cmd.CommandText);
                }
                else
                {
                    //Check in
                    cmd.CommandText = "insert into parking (`emp_no`, `date`, `checkin`, `front_in`, `rear_in`) ";
                    cmd.CommandText += "values ( '" + id + "', '" + date + "', '" + timeStamp + "', '" + absFrontImageDir + "', '" + absRearImageDir + "' );";              
                    lblCheckinStatus.Text = "XIN CHÀO";
                    Console.WriteLine("Line NOT exist: " + cmd.CommandText);
                }

                cmd.Connection = connection;

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getValueFromSettingForm();

            lblTime0.Visible = lblTime.Visible = isDisplayTime;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            cameraStatus = true;
            playCamera();
        }

        void playCamera()
        {
            if(imageDir == "")
            {
                MessageBox.Show("Please select directory to store image!");
                return;
            }
            if (frontCameraAddress == "")
            {
                MessageBox.Show("Please setup front camera URL!");
                return;
            }
            if (rearCameraAddress == "")
            {
                MessageBox.Show("Please setup rear camera URL!");
                return;
            }

            var uriFront = new Uri(frontCameraAddress);
            if(frontCameraStream.IsPlaying == false)
            {
                frontCameraStream.StartPlay(uriFront);
                lblFrontCamStatus.Text = "Front connecting...";
            }

            var uriRear = new Uri(rearCameraAddress);
            if (rearCameraStream.IsPlaying == false)
            {
                rearCameraStream.StartPlay(uriRear);
                lblRearCamStatus.Text = "Rear connecting...";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (frontCameraStream.IsPlaying)
            {
                frontCameraStream.Stop();
            }
            if (rearCameraStream.IsPlaying)
            {
                rearCameraStream.Stop();
            }
            cameraStatus = false;
        }

        private void UpdateButtons()
        {
            _playButton.Enabled = !(frontCameraStream.IsPlaying || rearCameraStream.IsPlaying);
            _stopButton.Enabled = frontCameraStream.IsPlaying || rearCameraStream.IsPlaying;
            this.ActiveControl = null;
        }

        private void FrontCamHandleStreamStartedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            lblFrontCamStatus.Text = "Playing";
        }

        private void FrontCamHandleStreamFailedEvent(object sender, StreamFailedEventArgs e)
        {
            UpdateButtons();

            lblFrontCamStatus.Text = "Can not connect to front camera";

            if (cameraStatus)
            {
                playCamera();
                Console.WriteLine("Stream failed event, trying to reconnect");
            }

            //MessageBox.Show("Can not connect to camera!", "Stream Player Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrontCamHandleStreamStoppedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            if (cameraStatus)
            {
                playCamera();
                Console.WriteLine("Stream failed event, trying to reconnect");
            }

            lblFrontCamStatus.Text = "Stopped";
        }

        private void rearCameraStream_StreamStarted(object sender, EventArgs e)
        {
            UpdateButtons();

            lblRearCamStatus.Text = "Playing";
        }

        private void rearCameraStream_StreamFailed(object sender, StreamFailedEventArgs e)
        {
            UpdateButtons();

            lblRearCamStatus.Text = "Can not connect to rear camera";
            if (cameraStatus)
            {
                playCamera();
                Console.WriteLine("Stream failed event, trying to reconnect");
            }
        }

        private void rearCameraStream_StreamStopped(object sender, EventArgs e)
        {
            UpdateButtons();

            if (cameraStatus)
            {
                playCamera();
                Console.WriteLine("Stream failed event, trying to reconnect");
            }

            lblRearCamStatus.Text = "Stopped";
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch
            {
            }
            return true;
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch
            {}
            return true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //close connection
                this.CloseConnection();
            }
            catch { }
        }

        private void chkTest_CheckedChanged(object sender, EventArgs e)
        {
            manualMode = chkTest.Checked;
        }

        private void employeesMotobikeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var appSetEmployeesData = new EmployeesData(connectionString);
            appSetEmployeesData.ShowDialog();

            Console.WriteLine("DATA done");

        }

        private void EmployeeManagement_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void EmployeeManagement_Resize(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void _stopButton_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LabelMotorNumber_Click(object sender, EventArgs e)
        {
            var appSetEmployeesData = new EmployeesData(lblId.Text, connectionString);
            appSetEmployeesData.ShowDialog();
            if (lblId.Text != "" && lblName.Text != "" && lblId.Text != "..." && lblName.Text !="...")
            {
                lblMotorNum.Text = appSetEmployeesData.motorNumToMainForm;
            }

            Console.WriteLine("DATA done");
        }
    }
}
