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

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        string k;
        public Form6(string k)
        {
            InitializeComponent();
            this.k = k;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadTable();
            if(k== "Student")
            {
               button4.Hide();
               button1.Hide();

            }
        }
        static string sql = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(sql);
        public DataTable LoadTable()
        {

            using (SqlConnection con = new SqlConnection(sql))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT 
                            a.UID, 
                            u.first_name, 
                            u.last_name, 
                            b.Title, 
                            b.author, 
                            b.price, 
                            b.publication_year 
                        FROM 
                            ADMIN a
                        JOIN 
                            [USER] u ON a.UID = u.UID
                        JOIN 
                            BOOK b ON a.UID = b.UID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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

        private void button4_Click(object sender, EventArgs e)
        {
           Form4 form = new Form4(k);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(k);  
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(k);  
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(k);  
            form.Show();
            this.Hide();
        }
    }
}
