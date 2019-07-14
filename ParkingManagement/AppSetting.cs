using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ozeki.Media;
using System.Text.RegularExpressions;
using MyDictionary = System.Collections.Generic.Dictionary<string, string>;

namespace EmployeeManagementApplicationSetting
{
    public partial class AppSetting : Form
    {
        public string cameraUrlFront = "";
        public string cameraUrlRear = "";
        public string imageDir = "";
        public string connectionString = "";
        public bool isDisplayTime = false;
        public int minTimeBetweenScanSteps = 3600; //second
        public int screenTimeoutValue = 60; //second

        //DB
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Store config
        MyDictionary globalDictionary = new MyDictionary();
        Configuration config;

        //Camera searcher
        private CameraURLBuilderWF myCameraUrlBuilder;
        private string[] cameralist = { ""};
        //private string[] cameralist = {
        //    "rtsp://192.168.1.119:554/user=admin_password=tlJwpbo6_channel=1_stream=0.sdp?real_stream",
        //    "rtsp://192.168.1.117:554/user=admin_password=tlJwpbo6_channel=1_stream=0.sdp?real_stream"
        //    };

        //Button OK clicked
        public bool isOKButtonClicked = false;

        public AppSetting()
        {
            InitializeComponent();
            intialValue();

            myCameraUrlBuilder = new CameraURLBuilderWF();

            config = new Configuration();

            updateAllFormValueFromDictionary(config.loadDictionaryFromFile());

            // Db tester + prepgress bar
            progressbarWorker.WorkerReportsProgress = true;
            progressbarWorker.WorkerSupportsCancellation = true;
            progressBar1.Visible = false;
        }

        void updateAllFormValueFromDictionary(MyDictionary readConfigDict)
        {
            if (readConfigDict.ContainsKey("camipfront") &&  readConfigDict["camipfront"] != "")
            {
                txtIpFront.Text = readConfigDict["camipfront"];
            }
            if (readConfigDict.ContainsKey("camportfront") && readConfigDict["camportfront"] != "")
            {
                txtPortFront.Text = readConfigDict["camportfront"];
            }
            if (readConfigDict.ContainsKey("camuserfront") && readConfigDict["camuserfront"] != "")
            {
                txtUserFront.Text = readConfigDict["camuserfront"];
            }
            if (readConfigDict.ContainsKey("campassfront") && readConfigDict["campassfront"] != "")
            {
                txtPasswdFront.Text = readConfigDict["campassfront"];
            }
            if (readConfigDict.ContainsKey("camindexfront") && readConfigDict["camindexfront"] != "")
            {
                cboxSuffixFront.SelectedIndex = Int32.Parse(readConfigDict["camindexfront"]);
            }
            if (readConfigDict.ContainsKey("urlfront") && readConfigDict["urlfront"] != "")
            {
                txtUrlFront.Text = readConfigDict["urlfront"];
            }


            if (readConfigDict.ContainsKey("camiprear") && readConfigDict["camiprear"] != "")
            {
                txtIpRear.Text = readConfigDict["camiprear"];
            }
            if (readConfigDict.ContainsKey("camportrear") && readConfigDict["camportrear"] != "")
            {
                txtPortRear.Text = readConfigDict["camportrear"];
            }
            if (readConfigDict.ContainsKey("camuserrear") && readConfigDict["camuserrear"] != "")
            {
                txtUserRear.Text = readConfigDict["camuserrear"];
            }
            if (readConfigDict.ContainsKey("campassrear") && readConfigDict["campassrear"] != "")
            {
                txtPasswdRear.Text = readConfigDict["campassrear"];
            }
            if (readConfigDict.ContainsKey("camindexrear") && readConfigDict["camindexrear"] != "")
            {
                cboxSuffixRear.SelectedIndex = Int32.Parse(readConfigDict["camindexrear"]);
            }
            if (readConfigDict.ContainsKey("urlrear") && readConfigDict["urlrear"] != "")
            {
                txtUrlRear.Text = readConfigDict["urlrear"];
            }

            if (readConfigDict.ContainsKey("imagedir") && readConfigDict["imagedir"] != "")
            {
                txtImageDir.Text = readConfigDict["imagedir"];
            }

            if (readConfigDict.ContainsKey("dbip") && readConfigDict["dbip"] != "")
            {
                txtDbIP.Text = readConfigDict["dbip"];
            }
            if (readConfigDict.ContainsKey("dbport") && readConfigDict["dbport"] != "")
            {
                txtDbPort.Text = readConfigDict["dbport"];
            }
            if (readConfigDict.ContainsKey("dbuser") && readConfigDict["dbuser"] != "")
            {
                txtDbUser.Text = readConfigDict["dbuser"];
            }
            if (readConfigDict.ContainsKey("dbpass") && readConfigDict["dbpass"] != "")
            {
                txtDbPasswd.Text = readConfigDict["dbpass"];
            }
            if (readConfigDict.ContainsKey("dbname") && readConfigDict["dbname"] != "")
            {
                txtDbName.Text = readConfigDict["dbname"];
            }

            if (readConfigDict.ContainsKey("displaytime") && readConfigDict["displaytime"] != "")
            {
                chkDisplayTime.Checked = readConfigDict["displaytime"].Contains("rue") ? true : false;
            }
            if (readConfigDict.ContainsKey("mintimescan") && readConfigDict["mintimescan"] != "")
            {
                int readValue = Int32.Parse(readConfigDict["mintimescan"]);
                if (readValue <minTimeScan.Minimum || readValue > minTimeScan.Maximum)
                {
                    readValue = 3600;
                }
                minTimeScan.Value = readValue;
            }
            if (readConfigDict.ContainsKey("screentimeout") && readConfigDict["screentimeout"] != "")
            {
                int readValue = Int32.Parse(readConfigDict["screentimeout"]);
                if (readValue < screenTimeout.Minimum || readValue > screenTimeout.Maximum)
                {
                    readValue = 60;
                }
                screenTimeout.Value = readValue;
            }
        }

        void updateDictionaryEvent()
        {
            globalDictionary["camipfront"] = txtIpFront.Text;
            globalDictionary["camportfront"] = txtPortFront.Text;
            globalDictionary["camuserfront"] = txtUserFront.Text;
            globalDictionary["campassfront"] = txtPasswdFront.Text;
            globalDictionary["camindexfront"] = cboxSuffixFront.SelectedIndex.ToString();
            globalDictionary["urlfront"] = txtUrlFront.Text;

            globalDictionary["camiprear"] = txtIpRear.Text;
            globalDictionary["camportrear"] = txtPortRear.Text;
            globalDictionary["camuserrear"] = txtUserRear.Text;
            globalDictionary["campassrear"] = txtPasswdRear.Text;
            globalDictionary["camindexrear"] = cboxSuffixRear.SelectedIndex.ToString();
            globalDictionary["urlrear"] = txtUrlRear.Text;

            globalDictionary["imagedir"] = txtImageDir.Text;
            globalDictionary["connectstring"] = this.connectionString;

            globalDictionary["dbip"] = txtDbIP.Text;
            globalDictionary["dbport"] = txtDbPort.Text;
            globalDictionary["dbuser"] = txtDbUser.Text;
            globalDictionary["dbpass"] = txtDbPasswd.Text;
            globalDictionary["dbname"] = txtDbName.Text;

            globalDictionary["displaytime"] = chkDisplayTime.Checked.ToString();
            globalDictionary["mintimescan"] = minTimeScan.Value.ToString();
            globalDictionary["screentimeout"] = screenTimeout.Value.ToString();
        }

        void intialValue()
        {
            string[] valueList = {
                "",
                "user=admin_password=tlJwpbo6_channel=1_stream=0.sdp?real_stream",
                "Streaming/Channels/1/",
                "Streaming/Channels/2/",
                "Streaming/Channels/101/",
                "Streaming/Channels/102/",
                "ch1/main/av_stream",
                "ch1/sub/av_stream",
                "1/d1"};

            foreach(string val in valueList )
            {
                cboxSuffixFront.Items.Add(val);
                cboxSuffixRear.Items.Add(val);
            }
            cboxSuffixFront.SelectedIndex = 1;
            cboxSuffixRear.SelectedIndex = 1;

            updateFrontUrlEvent();
            updateRearUrlEvent();
        }

        void updateFrontUrlEvent()
        {
            string ip       = txtIpFront.Text.Trim();
            string port     = txtPortFront.Text.Trim();
            string user     = txtUserFront.Text.Trim();
            string pass     = txtPasswdFront.Text.Trim();
            string suffix = cboxSuffixFront.Text + txtAddtionalSuffixFront.Text.Trim();

            txtUrlFront.Text = "rtsp://";
            if (user != "" && pass != "")
            {
                txtUrlFront.Text += user + ":" + pass + "@";
            }
            txtUrlFront.Text += ip + ":" + port + "/" + suffix;
        }

        void updateRearUrlEvent()
        {
            string ip = txtIpRear.Text.Trim();
            string port = txtPortRear.Text.Trim();
            string user = txtUserRear.Text.Trim();
            string pass = txtPasswdRear.Text.Trim();
            string suffix = cboxSuffixRear.Text + txtAddtionalSuffixRear.Text.Trim();

            txtUrlRear.Text = "rtsp://";
            if (user != "" && pass != "")
            {
                txtUrlRear.Text += user + ":" + pass + "@";
            }
            txtUrlRear.Text += ip + ":" + port + "/" + suffix;
        }


        string updateConnectionString()
        {
            server = txtDbIP.Text.Trim();
            database = txtDbName.Text.Trim();
            uid = txtDbUser.Text.Trim();
            password = txtDbPasswd.Text.Trim();
            string _connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            this.connectionString = _connectionString;
            return _connectionString;
        }

        string testConnection()
        {
            string result = "";
            result = "Connecting...";
            connection = new MySqlConnection(updateConnectionString());
            try
            {
                connection.Open();
                connection.Close();
                result = "Successful!";
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        result = "Cannot connect";
                        break;
                    case 1045:
                        result = "Invalid user/passwd";
                        break;
                    default:
                        result = "Cannot connect to host";
                        break;
                }
                MessageBox.Show("Exception: " + ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUrlFront.Text.Trim() == "" || txtUrlRear.Text.Trim() == "" || txtImageDir.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in the empty fields!");
                return;
            }
            cameraUrlFront = txtUrlFront.Text;
            cameraUrlRear = txtUrlRear.Text;
            imageDir = txtImageDir.Text;
            isDisplayTime = chkDisplayTime.Checked;
            minTimeBetweenScanSteps = Decimal.ToInt32(minTimeScan.Value);
            screenTimeoutValue = Decimal.ToInt32(screenTimeout.Value);
            updateConnectionString();

            updateDictionaryEvent();

            config.saveDictionaryToFile(globalDictionary);

            isOKButtonClicked = true;
            this.Close();
        }

        private void btnImageDirSelect_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    txtImageDir.Text = fbd.SelectedPath;
                }
            }

            updateDictionaryEvent();
        }

        private void cboxSuffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFrontUrlEvent();
            updateDictionaryEvent();
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            updateFrontUrlEvent();
            updateDictionaryEvent();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            updateDictionaryEvent();
        }
        private void txtImageDir_TextChanged(object sender, EventArgs e)
        {
            updateDictionaryEvent();
        }

        private void btnTestDb_Click(object sender, EventArgs e)
        {
            lblDbStatus.Text = "Connecting...";

            if (dbConnectionTester.IsBusy != true)
            {
                dbConnectionTester.RunWorkerAsync();

                if (progressbarWorker.WorkerSupportsCancellation == true)
                {
                    progressbarWorker.CancelAsync();
                }

                btnTestDb.Enabled = false;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                try
                {
                    progressbarWorker.RunWorkerAsync();
                }
                catch { }
            }
        }
        private void dbConnectionTester_DoWork(object sender, DoWorkEventArgs e)
        {
            string result = testConnection();
            e.Result = result;
        }

        private void dbConnectionTester_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnTestDb.Enabled = true;
            progressBar1.Visible = false;
            progressBar1.Value = 0;

            if (progressbarWorker.WorkerSupportsCancellation == true)
            {
                progressbarWorker.CancelAsync();
            }

            if (e.Error == null)
            {
                lblDbStatus.Text = (string)e.Result;
            }
        }

        private void progressbarWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(150);
                    worker.ReportProgress(i);
                }
            }
        }

        private void progressbarWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = Int32.Parse(e.ProgressPercentage.ToString());
        }

        private void txtDbIP_TextChanged(object sender, EventArgs e)
        {
            updateConnectionString();
        }

        private void btnFrontCamSelect_Click(object sender, EventArgs e)
        {
            var result = myCameraUrlBuilder.ShowDialog();

            if (result == DialogResult.OK)
            {
                string resultStr = myCameraUrlBuilder.CameraURL;
                Regex ip = new Regex(@"\b(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}):(\d+).*\b");
                Match match = ip.Match(resultStr);
                if (match.Success)
                {
                    string _ip = match.Groups[1].ToString();
                    txtIpFront.Text = _ip;
                    //txtPort.Text = match.Groups[2].ToString(); //port is not changed: 554
                    foreach (string url in cameralist)
                    {
                        if (url.Contains(_ip))
                        {
                            txtUrlFront.Text = url;
                            break;
                        }
                    }
                }
            }
        }

        private void btnRearCamSelect_Click(object sender, EventArgs e)
        {
            var result = myCameraUrlBuilder.ShowDialog();

            if (result == DialogResult.OK)
            {
                string resultStr = myCameraUrlBuilder.CameraURL;
                Regex ip = new Regex(@"\b(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}):(\d+).*\b");
                Match match = ip.Match(resultStr);
                if (match.Success)
                {
                    string _ip = match.Groups[1].ToString();
                    txtIpFront.Text = _ip;
                    //txtPort.Text = match.Groups[2].ToString(); //port is not changed: 554
                    foreach (string url in cameralist)
                    {
                        if (url.Contains(_ip))
                        {
                            txtUrlRear.Text = url;
                            break;
                        }
                    }
                }
            }
        }

        private void chkDisplayTime_CheckStateChanged(object sender, EventArgs e)
        {
            globalDictionary["displaytime"] = chkDisplayTime.Checked.ToString();
            Console.WriteLine(globalDictionary["displaytime"]);
        }

        private void txtIPRear_TextChanged(object sender, EventArgs e)
        {
            updateRearUrlEvent();
            updateDictionaryEvent();
        }

        private void cboxSuffixRear_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateRearUrlEvent();
            updateDictionaryEvent();
        }

        private void txtUrlRear_TextChanged(object sender, EventArgs e)
        {
            updateDictionaryEvent();
        }


    }
}
