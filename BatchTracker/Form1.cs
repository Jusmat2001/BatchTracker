using Advantage.Data.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
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

        string C1ConnString = "Server=SQL1\\SQL2005;DataBase=CodeOneMaster;UID=ReadOnlyUser;PWD=lij1Z96h";
        List<string> practiceList = new List<string>();
        public AdsConnection connection;
        public AdsCommand command;

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
            try
            {
                string sql = "SELECT BATCH_NUM, EMC_RECV, STATUS FROM Batch WHERE Status = 'Q';";
                string user = "User ID=admin;Password=admin;";
                string type = "ServerType=ADS_REMOTE_SERVER;SecurityMode=ADS_IGNORERIGHTS;";
                string sDataBase = "";
                string dataSource = "";
                string badpracs = "";

                DataTable mainTable = new DataTable();
                mainTable.Columns.Add("Practice", typeof(Int32), sDataBase);
                try
                {
                    practiceList = GetPractices();
                    if (practiceList != null)
                    {
                        for (int i = 0; i <= practiceList.Count - 1; i++)
                        {
                            //change conn string for each practice
                            sDataBase = practiceList[i];
                            dataSource = @"\\CLAIMS2\AltaData\" + sDataBase + @"\Data\AltaPoint.add;";
                            string connectionString = @"Data Source = " + dataSource + user + type;
                            connection = new AdsConnection { ConnectionString = connectionString };
                            //add row to differentiate practices between loops
                            DataRow row;
                            row = mainTable.NewRow();
                            row["Practice"] = sDataBase;
                            mainTable.Rows.Add(row);

                            using (connection)
                            {
                                try
                                {
                                    connection.Open();
                                    DataSet ds = new DataSet();
                                    IDataAdapter adapter;
                                    DataTable dt = new DataTable();

                                    adapter = new AdsDataAdapter(sql, connection);
                                    adapter.Fill(ds);
                                    dt = ds.Tables[0];
                                    mainTable.Merge(dt);
                                    ds.Clear();
                                }
                                catch (Exception ex)
                                {
                                    badpracs += sDataBase + ", ";
                                }
                            }
                        }
                    }

                    dataGridView1.DataSource = mainTable;
                    DataGridViewColumn column0 = dataGridView1.Columns[0];
                    column0.Width = 100;
                    DataGridViewColumn column1 = dataGridView1.Columns[1];
                    column1.Width = 100;
                    DataGridViewColumn column2 = dataGridView1.Columns[2];
                    column2.Width = 100;
                    DataGridViewColumn column3 = dataGridView1.Columns[3];
                    column2.Width = 100;
                    MessageBox.Show("Unable to retrieve " + badpracs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                //int line = (new StackTrace(ex, true)).GetFrame(FrameCount-1).GetFileLineNumber();
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string searchTerm = "";
            string practice = "";
            string sql = "SELECT BATCH_NUM, EMC_RECV, STATUS FROM Batch WHERE Status = 'Q';";
            string user = "User ID=admin;Password=admin;";
            string type = "ServerType=ADS_REMOTE_SERVER;SecurityMode=ADS_IGNORERIGHTS;";
            string sDataBase = "";
            string dataSource = "";
            try
            {
                if (SearchBox.Text.Count() < 3)
                {
                    MessageBox.Show("Please enter at least 3 numbers of the practice ID to search.");
                }
                else
                {
                    searchTerm = SearchBox.Text;
                    practice = searchTerm.Substring(0, 3);
                    if (practice != null)
                    {
                        if (practiceList.Contains(practice))
                        {
                            //set conn string and query practice
                            //set datagrid
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
