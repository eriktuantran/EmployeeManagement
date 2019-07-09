using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyDictionary = System.Collections.Generic.Dictionary<string, string>;

namespace WindowsFormsApplication1
{
    using StreamPlayerDemo;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using WebEye.Controls.WinForms.StreamPlayerControl;

    public partial class Form1 : Form
    {
        private string imageDir = "";
        private string connectionString = "";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        //Entering the ID manual
        private bool manualMode = false;

        private string cameraAddress = "";

        private string configFileDir = "";

        private bool isDisplayTime = false;


        string backgroundImageDir = Directory.GetCurrentDirectory() + "\\background.jpg";
        Bitmap backImage;


        //Prevent double scan in the very short time
        private Dictionary<string, DateTime> scaningState;
        private double minTimeBetweenScanSteps = 10;

        public Form1()
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
            if (cameraAddress == "" || connectionString == "" || imageDir == "")
            {
                getValueFromSettingForm();
            }

            // Display time
            lblTime0.Visible = lblTime.Visible = isDisplayTime;

            //SQL connection
            connection = new MySqlConnection(connectionString);

            //Automatic start camera
            playCamera();

            //Background Image
            backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundImage.Visible = true;
            try
            {
                backImage = new Bitmap(backgroundImageDir);
                backgroundImage.Image = (Image)backImage;
            }
            catch
            {
                Console.WriteLine("Background image not found: " + backgroundImageDir);
            }
        }

        void populateFormIntialValue(MyDictionary dict)
        {
            if (dict.ContainsKey("url") && dict["url"] != "")
            {
                cameraAddress = dict["url"];
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
        }

        void getValueFromSettingForm()
        {
            var appSetting = new AppSetting();
            appSetting.ShowDialog();

            //Collect Data
            cameraAddress = appSetting.cameraUrl;
            imageDir = appSetting.imageDir;
            connectionString = appSetting.connectionString;
            connection = new MySqlConnection(connectionString);
            isDisplayTime = appSetting.isDisplayTime;
            minTimeBetweenScanSteps = appSetting.minTimeBetweenScanSteps;

            Console.WriteLine("Setting done");
        }

        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);

            if (!manualMode)
            {
                if (elapsed.TotalMilliseconds > 100)
                    _barcode.Clear();
            }

            if(manualMode && e.KeyChar == Convert.ToChar(Keys.Back))
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
                        lblName.Text = txtRole.Text = lblTime.Text = "";
                        picBoxEmployee.Image = null;
                    }
                }
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
                    lblId.Text = lblName.Text = txtRole.Text = lblTime.Text = "";
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
                        lblId.Text = "Updated! Pls wait: " + remain.ToString() + " second";
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
                string absImageDir = captureCamera();
                try
                {
                    updateTimeInOut(empId, absImageDir);
                    displayNameAndImage(empId);
                    displayTime();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection ERROR: "+ex.Message, "Lost database connection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void displayTime()
        {
            DateTime now = DateTime.Now;
            string timeStamp = now.ToString("yyyy-MM-dd HH:mm:ss");
            lblTime.Text = timeStamp;
        }

        string captureCamera()
        {
            try
            {
                string now = DateTime.Now.ToString("-yyyy-MM-ddTHH-mm-ss");
                string filename = imageDir +"\\"+ lblId.Text + now + ".bmp";
                Console.WriteLine(filename);
                streamPlayerControl1.GetCurrentFrame().Save(filename);
                return filename;
            }
            catch { }
            return "";
        }

        private void displayNameAndImage(string id)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select last_name,first_name,bophan_id from employees where emp_no='" + id + "';";

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            if (lblName.Text != "")
            {
                updateImage(id);
            }
            else
            {
                picBoxEmployee.Image = null;
            }

        }

        string imageFileSearchById(string dir, string id)
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
                    imageFileSearchById(subDir, id);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fileName;
        }

        private void updateImage(string id)
        {
            string baseDir = Directory.GetCurrentDirectory();
            string absImageFile = imageFileSearchById(baseDir, id);
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

        private bool isRowExist(string id, string date)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select emp_no from checkin where emp_no='"+id+"' and date='" + date + "' and checkout is NULL;";

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

        private void updateTimeInOut(string id, string imagePath2DB)
        {
            DateTime now = DateTime.Now;
            string timeStamp = now.ToString("yyyy-MM-dd HH:mm:ss");
            string date = now.ToString("yyyy-MM-dd");
            bool rowExist = isRowExist(id, date);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                if (rowExist)
                {
                    // Check out
                    if (imagePath2DB == "")
                    {
                        cmd.CommandText = "update checkin set checkout=CURRENT_TIMESTAMP where emp_no='" + id + "' and date='" + date + "' and checkout is NULL;";
                    }
                    else
                    {
                        cmd.CommandText = "update checkin set checkout=CURRENT_TIMESTAMP,pic2='" + imagePath2DB + "' where emp_no='" + id + "' and date='" + date + "' and checkout is NULL;";
                    }
                    Console.WriteLine("Line exist: " + cmd.CommandText);
                }
                else
                {
                    //Check in
                    if (imagePath2DB == "")
                    {
                        cmd.CommandText = "insert into checkin (`emp_no`, `date`, `checkin`) values ( '" + id + "', '" + date + "', '" + timeStamp + "');";
                    }
                    else
                    {
                        cmd.CommandText = "insert into checkin (`emp_no`, `date`, `checkin`, `pic1`) values ( '" + id + "', '" + date + "', '" + timeStamp + "', '" + imagePath2DB + "' );";
                    }
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
            playCamera();
        }

        void playCamera()
        {
            if (cameraAddress == "" || imageDir == "")
            {
                MessageBox.Show("Please select camera!");
                return;
            }

            var uri = new Uri(cameraAddress);
            streamPlayerControl1.StartPlay(uri);
            lblStatus.Text = "Connecting...";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            streamPlayerControl1.Stop();
            backgroundImage.Visible = true;
        }

        private void UpdateButtons()
        {
            _playButton.Enabled = !streamPlayerControl1.IsPlaying;
            _stopButton.Enabled = streamPlayerControl1.IsPlaying;
            this.ActiveControl = null;
        }

        private void HandleStreamStartedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            lblStatus.Text = "Playing";
            backgroundImage.Visible = false;
        }

        private void HandleStreamFailedEvent(object sender, StreamFailedEventArgs e)
        {
            UpdateButtons();

            lblStatus.Text = "Can not connect to camera";
            backgroundImage.Visible = true;

            //MessageBox.Show("Can not connect to camera!", "Stream Player Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleStreamStoppedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            lblStatus.Text = "Stopped";
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


    }
}
