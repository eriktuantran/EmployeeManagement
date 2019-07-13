using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class EmployeesData : Form
    {

        private string connectionString = "";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        private string empIdFormMainForm = "";

        public string motorNumToMainForm = "";

        public EmployeesData(string empId, string connStr)
        {
            InitializeComponent();

            this.connectionString = connStr;

            //SQL connection
            connection = new MySqlConnection(connectionString);

            txtID.Text = empId;
            empIdFormMainForm = empId;
            displayNameAndImage(empId);
        }

        public EmployeesData(string connStr)
        {
            
            InitializeComponent();

            this.connectionString = connStr;

            //SQL connection
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtUrl.Text == "" || txtImageDir.Text == "")
            {
                //MessageBox.Show("Please fill in the empty fields!");
                //return;
            }

            this.Close();
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
                Console.WriteLine(ex.ToString());
            }
            CloseConnection();
            return false;
        }

        private bool isNumberRowExistForEmployee(string id)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "select emp_no from bienso where emp_no='" + id + "' ;";

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
                    txtMotorNum.Text = motorNum;
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
            if (absImageFile == "")
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string empId = txtID.Text.Trim();

            if (!validateEmployee(empId))
            {
                return;
            }

            displayNameAndImage(empId);
        }

        bool validateEmployee(string empId)
        {
            if (empId == "")
            {
                lblName.Text = txtRole.Text = txtMotorNum.Text = "";
                picBoxEmployee.Image = null;
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                return false;
            }
            // Employee exist or not
            if (!isEmployeeExist(empId))
            {
                lblName.Text = txtRole.Text = txtMotorNum.Text = "";
                picBoxEmployee.Image = null;
                Console.WriteLine("Employee does not exist: " + empId);
                MessageBox.Show("Nhân viên không tồn tại\nVui lòng liên hệ quản trị viên!");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaveSuccess = false;
            DateTime now = DateTime.Now;
            string timeStamp = now.ToString("yyyy-MM-dd HH:mm:ss");
            string date = now.ToString("yyyy-MM-dd");

            string empId = txtID.Text.Trim();

            if (!validateEmployee(empId))
            {
                return;
            }

            bool rowExist = isNumberRowExistForEmployee(empId);
            string motorNum = txtMotorNum.Text.Trim();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                if (rowExist)
                {
                    
                    cmd.CommandText = "update bienso set num='" + motorNum + "' where emp_no="+empId+";";
                    Console.WriteLine("Line exist: " + cmd.CommandText);
                }
                else
                {
                    
                    cmd.CommandText = "insert into bienso (`emp_no`, `num`) values ('"+ empId + "','"+motorNum+"') ;";
                }

                try
                {
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    isSaveSuccess = true;
                    MessageBox.Show("Lưu thành công!");
                }
                catch
                {
                    MessageBox.Show("Không thể lưu!\nVui lòng kiểm tra máy chủ...");
                }
                this.CloseConnection();
            }

            if (empIdFormMainForm != ""&& isSaveSuccess ==true) // event clicking main form label
            {
                motorNumToMainForm = txtMotorNum.Text.Trim();
                this.Close();
            }
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
            { }
            return true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

            string empId = txtID.Text.Trim();

            if (empId.Length >= 6)
            {
                if (!validateEmployee(empId))
                {
                    return;
                }

                displayNameAndImage(empId);
            }
            else
            {
                lblName.Text = txtRole.Text = txtMotorNum.Text = "";
                picBoxEmployee.Image = null;
            }
        }
    }
}
