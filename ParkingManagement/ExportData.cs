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
using MySql.Data.MySqlClient;

namespace EmployeeManagementApplicationSetting
{
    public partial class ExportData : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;



        public ExportData()
        {
            InitializeComponent();
            initializeDatabase();
        }


        void tabelaSmetka(DataTable tabela)
        {
            //ExcelLibrary.DataSetHelper.CreateWorkbook(nm, dds);
            //ws.Name = tabela.TableName;
            //wb.SaveAs(@"D:\artikli.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue);
            //wb.Close(true, missValue, missValue);
            //MessageBox.Show("Податоците беа успешно префрлени во Excel !");
        }


        private void initializeDatabase()
        {
            server = "localhost";
            database = "employees";
            uid = "root";
            password = "rootroot";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Allow User Variables = True";
            connection = new MySqlConnection(connectionString);

            performQuery();

            //if (this.OpenConnection() == true)
            //{
            //    //Business logic
            //    string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //    mySqlDataAdapter = new MySqlDataAdapter("select * from checkin_out where work_date='"+ date +"';", connection);
            //    DataSet DS = new DataSet();
            //    mySqlDataAdapter.Fill(DS);

            //    dataGridView1.DataSource = DS.Tables[0];
            //}
        }

        private void performQuery()
        {
            if (this.OpenConnection() == true)
            {
                //Business logic
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string query =
@"set @diff='00:00:00';
select  checkin_out.emp_no as 'Ma So',
        employees.last_name as 'Ho',
        employees.first_name as 'Ten',
        checkin_out.time_in as 'Gio vao',
        checkin_out.time_out as 'Gio ra',
        @diff := TIMEDIFF(time_out, time_in) as 'Tong gio',
        IF(HOUR(@diff) > 8, HOUR(TIMEDIFF(@diff, '08:00:00')), 0) as 'Tang ca'
from checkin_out
    left join employees on checkin_out.emp_no = employees.emp_no
where checkin_out.work_date = '" + date + "' order by checkin_out.time_in ASC ; ";
                //        HOUR(TIMEDIFF(@diff, '08:00:00')) as 'Tang ca'
                try
                {
                    mySqlDataAdapter = new MySqlDataAdapter(query, connection);

                    DataSet DS = new DataSet();
                    mySqlDataAdapter.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch { }
                this.CloseConnection();
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
                return true;
            }
            catch
            { 
                return false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            performQuery();
        }

        private void ExportData_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //close connection
                this.CloseConnection();
            }
            catch { }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var sb = new StringBuilder();

                var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                //sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                sb.AppendLine("Ma so,Ho,Ten,Gio vao,Gio ra,Tong gio,Tang ca");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
                saveFileDialog1.Title = "Save csv Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                saveFileDialog1.FileName = date+".csv";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());

                    StreamWriter sw11 = new StreamWriter(saveFileDialog1.FileName, true, Encoding.Unicode);
                    sw11.WriteLine(sb.ToString());
                    sw11.Close();
                }
                MessageBox.Show("Success!");
            }
            catch { }
        }
    }
}
