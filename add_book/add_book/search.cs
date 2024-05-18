using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Library
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=DESKTOP-99VP6K8;Initial Catalog=project3;Integrated Security=True;Encrypt=False";

        private DataTable search1()
        {
            string query1 = @"
              SELECT Title, price, author, publication_year, B_ISBN , C_NAME ,name
              FROM BOOK , DEPARTMENT
              WHERE BOOK.DPID = DEPARTMENT.DPID AND
              (Title LIKE '%' + @parm1 + '%' 
              OR C_NAME LIKE '%' +@parm1 + '%'
              OR price LIKE '%' + @parm1 + '%' 
              OR author LIKE '%' + @parm1 + '%' 
              OR publication_year LIKE '%' + @parm1 + '%' 
              OR B_ISBN LIKE '%' + @parm1 + '%'
              OR name LIKE '%' + @parm1 + '%'  )";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("parm1", sc.Text);
                        SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                        DataTable data_table = new DataTable();
                        data_adapter.Fill(data_table);
                        dataGridView1.DataSource = data_table;
                        return data_table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is currently not being used. You can implement it if needed.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Correct placement and structure of using block
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Title, price, author, publication_year, B_ISBN , C_NAME ,name FROM BOOK ,DEPARTMENT  WHERE BOOK.DPID = DEPARTMENT.DPID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                        DataTable data_table = new DataTable();
                        data_adapter.Fill(data_table);
                        dataGridView1.DataSource = data_table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void sc_TextChanged(object sender, EventArgs e)
        {
            search1();
        }

       
    }
}



