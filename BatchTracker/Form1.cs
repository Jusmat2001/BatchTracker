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
                practiceListView.GridLines = true;

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
            string sql = "SELECT * FROM Batch WHERE Status = 'Q';";
            OleDbDataReader reader;
            string sDataBase = "";
            string connectionString = "Data Source=\\\\Claims2\\AltaData\\" + sDataBase + "\\Data\\AltaPoint.add;User ID=admin;Password=admin;";

            try
            {
                var practices = GetPractices();
                if (practices != null)
                {
                    foreach (string prac in practices)
                    {

                    }
                }

                //DataSet ds = new DataSet();
                //            dataadapter.Fill(ds, "TestAPdb");
                //            dataGridView1.DataSource = ds;
                //            dataGridView1.DataMember = "TestAPdb";

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

        private void Search_btn_Click(object sender, EventArgs e)
        {
            
            string searchTerm = "";
            string practice = "";
            try
            {
                if (SearchBox.Text.Count() < 3)
                {
                    MessageBox.Show("Please enter at least 3 numbers to search.");
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

            string sql = "SELECT * FROM TestAPdb WHERE Batch# LIKE '%"+searchTerm+"%'";
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
