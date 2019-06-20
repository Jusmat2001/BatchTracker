using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BatchTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string connectionString = "";
        string C1ConnString = "Server=SQL1\\SQL2005;DataBase=CodeOneMaster;UID=ReadOnlyUser;PWD=lij1Z96h";
        List<string> practiceList = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                practiceList = GetPractices();
                if (practiceList!=null)
                {
                    foreach (string prac in practiceList)
                    {
                        practiceListView.Items.Add(prac);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> GetPractices()
        {
            string listQuery = "SELECT PracticeIdentifier FROM dbo.Practice Order by PracticeIdentifier";
            List<string> list = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(C1ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(listQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(reader.GetString(0));
                            }
                            list.Remove("100");
                            list.Remove("998");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        private void Populate_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn;
            OleDbCommand cmd;
            string sql = "SELECT BATCH_NUM, EMC_RECV, STATUS FROM Batch WHERE Status = 'Q';";
            string sDataBase = "";
            DataSet ds = new DataSet();
            //string provider = "Provider=Microsoft.Jet.OLEDB.4.0;";
            string provider = "Provider=Advantage Client Engine SDK x86_64 v10.0;";
            string dataSource = "";
            string user = "User ID = admin; Password = admin; Advantage Server Type = ADS_REMOTE_SERVER; SecurityMode = ADS_IGNORERIGHTS;";// Cannot find installable ISAM
            //"Jet OLEDB: Database Password = admin;"; <-- workgroup info is missing or opened exclusively by another user

            try
            {
                practiceList = GetPractices();
                if (practiceList != null)
                {
                    foreach (string prac in practiceList)
                    {
                        //change conn string for each practice
                        sDataBase = prac;
                        dataSource = @"Data Source = \\CLAIMS2\AltaData\" + sDataBase + @"\Data\AltaPoint.add;";
                        connectionString = provider + dataSource + user;
                        // loop, build connstring, query, add to da
                        using (cnn = new OleDbConnection(connectionString))
                        {
                            cnn.Open();
                            cmd = new OleDbCommand(sql, cnn);
                            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                            adapter.Fill(ds);
                        }
                    }
                }
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "practiceList";
                DataGridViewColumn column0 = dataGridView1.Columns[0];
                column0.Width = 275;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 100;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(System.Environment.MachineName.ToString());
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            string searchTerm = "";
            string practice = "";
            try
            {
                if (SearchBox.Text.Count() < 3)
                {
                    MessageBox.Show("Please enter at least 3 numbers starting with the practice ID to search.");
                }
                else
                {
                    searchTerm = SearchBox.Text;
                    practice = searchTerm.Substring(0, 3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string sql = "SELECT * FROM TestAPdb WHERE Batch# LIKE '%" + searchTerm + "%'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection))
                    {
                        DataSet ds = new DataSet();
                        dataadapter.Fill(ds, "TestAPdb");
                        connection.Close();
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "TestAPdb";
                    }
                }
                DataGridViewColumn column0 = dataGridView1.Columns[0];
                column0.Width = 275;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 100;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
