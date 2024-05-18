using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Book_Library;

namespace add_book
{
    public partial class add_book : Form
    {
        public add_book()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
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

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-99VP6K8;Initial Catalog=project3;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into BOOK (Title,price,author,publication_year,B_ISBN,DPID,C_NAME,UID) values ('" + b_name + "','" + b_price + "','" + b_author + "','" + b_year + "','" + b_isbn + "','" + b_dpid + "','" + b_cname + "','" + b_uid + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Book added successfly ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search searchf = new search();
            searchf.Show();
            this.Hide();
        }
    }
}
