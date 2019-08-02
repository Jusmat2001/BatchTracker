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
        public AdsCommand command; string sUser = "User ID=admin;Password=admin;";
        string sType = "ServerType=ADS_REMOTE_SERVER;SecurityMode=ADS_IGNORERIGHTS;";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                practiceList = GetPractices();
                if (practiceList!=null)
                {
                    foreach (string prac in practiceList)
                    {
                        lbPracticeListbox.Items.Add(prac);
                    }
                    lbPracticeListbox.ColumnWidth = 55;
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
                            if (list.Contains("100")) { list.Remove("100"); }
                            if (list.Contains("998")) { list.Remove("998"); }
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
                string sSql = "SELECT BATCH_NUM, EMC_RECV, STATUS FROM Batch WHERE Status = 'Q';";
                //string sUser = "User ID=admin;Password=admin;";
                //string sType = "ServerType=ADS_REMOTE_SERVER;SecurityMode=ADS_IGNORERIGHTS;";
                string sDataBase = "";
                string sDataSource = "";
                string sBadpracs = "";
                
                Application.UseWaitCursor = true;
                this.UseWaitCursor = true;
                int iBatchcount = 0;

                DataTable mainTable = new DataTable();
                mainTable.Columns.Add("Practice", typeof(Int32), sDataBase);
                try
                {
                    practiceList = GetPractices();
                    if (practiceList != null)
                    {
                        //MessageBox.Show("loop");
                        for (int i = 0; i <= practiceList.Count - 1; i++)
                        {
                            //change conn string for each practice
                            sDataBase = practiceList[i];
                            sDataSource = @"\\CLAIMS2\AltaData\" + sDataBase + @"\Data\AltaPoint.add;";
                            string connectionString = @"Data Source = " + sDataSource + sUser + sType;
                            connection = new AdsConnection { ConnectionString = connectionString };
                            
                            using (connection)
                            {
                                try
                                {
                                    connection.Open();
                                    DataSet ds = new DataSet();
                                    DataTable dt = new DataTable();
                                    IDataAdapter adapter = new AdsDataAdapter(sSql, connection);
                                    
                                    adapter.Fill(ds);
                                    iBatchcount += ds.Tables[0].Rows.Count;
                                    if (ds.Tables[0].Rows.Count >0)
                                    {
                                        DataRow row;
                                        row = mainTable.NewRow();
                                        row["Practice"] = sDataBase;
                                        mainTable.Rows.Add(row);
                                        dt = ds.Tables[0];
                                        mainTable.Merge(dt);
                                    }
                                    ds.Clear();
                                }
                                catch (Exception ex)
                                {
                                    //MessageBox.Show(ex.Message);
                                    sBadpracs += sDataBase + ", ";
                                }
                            }
                        }
                    }
                    //MessageBox.Show("Loop done");
                    dataGridView1.DataSource = mainTable;
                    MessageBox.Show("Unable to retrieve " + sBadpracs);
                    LabelBox.Text = iBatchcount + " queued batches counted.";
                    
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite.ToString());
                    MessageBox.Show(ex.StackTrace);
                    MessageBox.Show(ex.Source);
                    MessageBox.Show(ex.InnerException.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Application.UseWaitCursor = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            var checkedButton = SearchGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton == null) { MessageBox.Show("Please select a search type"); }
            else if (bDateRangeBtn.Checked == true)
            {
                TimeSpan span = startDateTimePicker.Value - endDateTimePicker.Value;
                if (span.TotalDays>365) { MessageBox.Show("Please make the date range less than 1 year."); return; }
                else
                {
                    string start, end;
                    if (startDateTimePicker.Value != null) { start = startDateTimePicker.Value.ToString("yyyy-MM-dd"); }
                    if (endDateTimePicker.Value != null) { end = endDateTimePicker.Value.ToString("yyyy-MM-dd"); }
                    string practice = lbPracticeListbox.SelectedItem.ToString();
                    //DateSearch(start, end, practice);
                }
                

            }
            else if (bBatchNumberBtn.Checked == true)
            {
                string batchnumber = BatchNumberSearchBox.Text;
                BatchNumberSearch(batchnumber);
            }
        }
        
        public void DateSearch(string start, string end, string practice)
        {
            //string sSql = 
        }

        public void BatchNumberSearch(string batchnumber)
        {
            // substing get prac
            string sSql = "Select Distinct Batch_Num, EMC_RECV, Status, BH.Date From Batch Join [Billing History] BH ON Batch_Num = BH.Batch WHERE Batch_Num = "+batchnumber;
            //string sUser = "User ID=admin;Password=admin;";
            //string sType = "ServerType=ADS_REMOTE_SERVER;SecurityMode=ADS_IGNORERIGHTS;";
            var sDataBase = batchnumber.Substring(0, 3);
            var sDataSource = @"\\CLAIMS2\AltaData\" + sDataBase + @"\Data\AltaPoint.add;";
            string connectionString = @"Data Source = " + sDataSource + sUser + sType;
            connection = new AdsConnection { ConnectionString = connectionString };
            //query for batch # and display
            using (connection)
            {
                try
                {
                    connection.Open();
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    IDataAdapter adapter = new AdsDataAdapter(sSql, connection);
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dt = ds.Tables[0];
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void BatchRangeSearch(string firstBatch, string secondBatch)
        {
            //substring both for prac and compare. if both same continue

        }
         
    }
}
