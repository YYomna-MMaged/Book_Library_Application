using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string ko;
        public Form1(string k)
        {
            InitializeComponent();
            this.ko = k ;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

      
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search1();

        }

        private const string connectionString = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True;Encrypt=False";

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
                        cmd.Parameters.AddWithValue("parm1", textBox1.Text);
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
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is currently not being used. You can implement it if needed.
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            search1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(ko);  
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(ko);
            form3.Show(); 
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ko);
            form4.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (ko == "Student")
            {
                button4.Hide();
                button3.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(ko);
            form6.Show();
            this.Hide();
        }
    }
}
