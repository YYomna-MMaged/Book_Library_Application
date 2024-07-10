using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        string k;
        public Form3(string k)
        {
            InitializeComponent();
            this.k = k;
        }
        static string sql = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(sql);
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable();
            if(k == "Student")
            {
                button4.Hide();
                button1.Hide();
                button3.Hide();
            }
        }
        public DataTable LoadUserTable()
        {

            DataTable data_table = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();
                    string query = "SELECT u.*, p.phone_number " +
                                   "FROM [USER] u " +
                                   "LEFT JOIN USER_PHONE p ON u.UID = p.user_id " +
                                   "WHERE u.UID NOT IN (SELECT uid FROM admin)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                        data_adapter.Fill(data_table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return data_table;

            //  DataTable dt = new DataTable();
            // string query = "SELECT u.*, p.phone_number FROM [USER] u LEFT JOIN USER_PHONE p ON u.UID = p.user_id";
            //con.Open();
            /// SqlCommand cmd = new SqlCommand(query, con);
            //  SqlDataAdapter da = new SqlDataAdapter(cmd);
            // da.Fill(dt);
            // con.Close();
            // return dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (string.IsNullOrEmpty(textfname.Text) || string.IsNullOrEmpty(textmail.Text) || string.IsNullOrEmpty(textpass.Text))
                {
                    MessageBox.Show("Please fill in these fields: First Name, Email, and Password.");
                    return;
                }

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string UID = Convert.ToString(selectedRow.Cells["UID"].Value);
                string originalPhoneNumber = GetValueOrNull(selectedRow.Cells["phone_number"]);


                if (UID != textuid.Text && !string.IsNullOrEmpty(textuid.Text))
                {
                    MessageBox.Show("You are attempting to change the UID. This action is not allowed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textuid.Text = UID;
                    return;
                }

                con.Open();
                string query = "UPDATE [USER] SET password = @password, email = @email,"
                             + "first_name = @first_name, last_name = @last_name,"
                             + "city = @city,  street = @street WHERE UID = @UID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@password", textpass.Text);
                cmd.Parameters.AddWithValue("@email", textmail.Text);
                cmd.Parameters.AddWithValue("@first_name", textfname.Text);
                cmd.Parameters.AddWithValue("@last_name", textlname.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@city", textcity.Text ?? (object)DBNull.Value);
              //  cmd.Parameters.AddWithValue("@building", textbuilding.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@street", textstreet.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UID", UID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("UPDATED SUCCESSFULLY");
                con.Close();
                dataGridView1.DataSource = LoadUserTable();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private string GetValueOrNull(DataGridViewCell cell)
        {
            return cell?.Value?.ToString() ?? string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 browse = new Form1(k);
            browse.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(k);  
            form2.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow != null)
                {
                    textpass.Text = GetValueOrNull(selectedRow.Cells["password"]);
                    textmail.Text = GetValueOrNull(selectedRow.Cells["email"]);
                    textfname.Text = GetValueOrNull(selectedRow.Cells["first_name"]);
                    textlname.Text = GetValueOrNull(selectedRow.Cells["last_name"]);
                    textcity.Text = GetValueOrNull(selectedRow.Cells["city"]);
                    // textbuilding.Text = GetValueOrNull(selectedRow.Cells["building"]);
                    textstreet.Text = GetValueOrNull(selectedRow.Cells["street"]);
                    textuid.Text = GetValueOrNull(selectedRow.Cells["UID"]);


                    string phoneNumbers = "";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["UID"].Value != null && row.Cells["UID"].Value.ToString() == textuid.Text)
                        {
                            phoneNumbers += GetValueOrNull(row.Cells["phone_number"]) + ", ";
                        }
                    }
                  
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4=new Form4(k);
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string UID = Convert.ToString(dataGridView1.CurrentRow.Cells["UID"].Value);
            string query = "DELETE FROM [USER] where password = @password and email = @email and "
                             + "first_name = @first_name and last_name = @last_name and "
                             + "city = @city and street = @street";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@password", textpass.Text);
            cmd.Parameters.AddWithValue("@email", textmail.Text);
            cmd.Parameters.AddWithValue("@first_name", textfname.Text);
            cmd.Parameters.AddWithValue("@last_name", textlname.Text ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@city", textcity.Text ?? (object)DBNull.Value);
            //  cmd.Parameters.AddWithValue("@building", textbuilding.Text ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@street", textstreet.Text ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@UID", UID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Successfully!");
            dataGridView1.DataSource = LoadUserTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(k);
            form6.Show();
            this.Hide();
        }
    }
}
