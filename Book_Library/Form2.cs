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
    public partial class Form2 : Form
    {
        string k;
        public Form2(string k)
        {
            InitializeComponent();
            this.k = k;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (k == "Student")
            {
                button3.Hide();
            }
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            string b_name = title.Text; 
            string b_author = author.Text;
            string b_cname = cname.Text;
            Int64 b_year = Int64.Parse(pubYear.Text);
            Int64 b_price = Int64.Parse(price.Text); 
            Int64 b_isbn = Int64.Parse(isbn.Text);
            Int64 b_dpid = Int64.Parse(dpid.Text);
            Int64 b_uid = Int64.Parse(uid.Text);           
            // Int64 b_bor_uid = Int64.Parse(borroe_uid.Text);
            // Int64 b_bor_isbn = Int64.Parse(borrow_isbn.Text);
            SqlConnection con = new SqlConnection(); con.ConnectionString = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand(); cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into BOOK (Title,price,author,publication_year,B_ISBN,DPID,C_NAME,UID) values ('" + b_name + "','" + b_price + "','" + b_author + "','" + b_year + "','" + b_isbn + "','" + b_dpid + "','" + b_cname + "','" + b_uid + "')"; 
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book added successfly ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 browse = new Form1(k);
            browse.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(k);
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(k);  
            form4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(k); 
            form6.Show();
            this.Hide();
        }
    }
}
