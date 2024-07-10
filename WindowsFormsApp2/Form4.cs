using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        string k;
        public Form4(string k)
        {
            InitializeComponent();
            this.k = k;
        }
        static string sql = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        private void Form4_Load(object sender, EventArgs e)
        {
   
            dataGridView1.DataSource = loadUserTable();
        }
        public DataTable loadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Book";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)   // select current row and show it in box
        {
          
        }
        private string GetValueOrNull(DataGridViewCell cell)
        {
            return cell?.Value?.ToString() ?? string.Empty;
        }


        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();
            string UID = Convert.ToString(dataGridView1.CurrentRow.Cells["UID"].Value);
            string query = "UPDATE Book SET Title=@BookTitle , price=@BookPrice , author=@Author , B_ISBN=@BookID, DPID=@DepID ,publication_year=@PublicationYear ,UID=@UID WHERE B_ISBN=@BOOKID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookTitle", textBookTitle.Text);
            cmd.Parameters.AddWithValue("@BookPrice", texBookPrice.Text);
            cmd.Parameters.AddWithValue("@Author", textAutror.Text);
            cmd.Parameters.AddWithValue("@PublicationYear", textPubYear.Text);
            cmd.Parameters.AddWithValue("@BookId", textBOOKID.Text);
            cmd.Parameters.AddWithValue("@DepID", textDID.Text);
            cmd.Parameters.AddWithValue("@UID", UID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully!");
            dataGridView1.DataSource = loadUserTable();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 user = new Form3(k);
            user.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            textBookTitle.Text = GetValueOrNull(selectedRow.Cells["Title"]);
            textBOOKID.Text = GetValueOrNull(selectedRow.Cells["B_ISBN"]);
            texBookPrice.Text = GetValueOrNull(selectedRow.Cells["price"]);
            textAutror.Text = GetValueOrNull(selectedRow.Cells["author"]);
            textDID.Text = GetValueOrNull(selectedRow.Cells["DPID"]);
            textPubYear.Text = GetValueOrNull(selectedRow.Cells["publication_year"]);
            textADMINID.Text = GetValueOrNull(selectedRow.Cells["UID"]);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(k);  
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(k);  
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string UID = Convert.ToString(dataGridView1.CurrentRow.Cells["UID"].Value);
            string query = "DELETE FROM Book WHERE Title=@BookTitle AND price=@BookPrice AND author=@Author AND B_ISBN=@BookID AND DPID=@DepID AND publication_year=@PublicationYear AND UID=@UID ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookTitle", textBookTitle.Text);
            cmd.Parameters.AddWithValue("@BookPrice", texBookPrice.Text);
            cmd.Parameters.AddWithValue("@Author", textAutror.Text);
            cmd.Parameters.AddWithValue("@PublicationYear", textPubYear.Text);
            cmd.Parameters.AddWithValue("@BookId", textBOOKID.Text);
            cmd.Parameters.AddWithValue("@DepID", textDID.Text);
            cmd.Parameters.AddWithValue("@UID", UID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DELETE Successfully!");
            dataGridView1.DataSource = loadUserTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(k);
            form6.Show();
            this.Hide();
        }
    }
}
