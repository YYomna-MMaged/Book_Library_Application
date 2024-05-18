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

namespace Book_Library
{
    public partial class Form1 : Form
    {
        static string sql = "Data Source=DESKTOP-99VP6K8;Initial Catalog=project3;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable userTable = LoadUserTable();
            if (userTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = userTable;
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        public DataTable LoadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT u.*, p.phone_number FROM [USER] u LEFT JOIN USER_PHONE p ON u.UID = p.user_id";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
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

                if (originalPhoneNumber != textphone.Text && !string.IsNullOrEmpty(textphone.Text))
                {
                    MessageBox.Show("You are attempting to change the phone number. This action is not allowed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textphone.Text = originalPhoneNumber;
                    return;
                }

                if (UID != textuid.Text && !string.IsNullOrEmpty(textuid.Text))
                {
                    MessageBox.Show("You are attempting to change the UID. This action is not allowed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textuid.Text = UID;
                    return;
                }

                try
                {
                    con.Open();
                    string query = "UPDATE [USER] SET password = @password, email = @email, first_name = @first_name, last_name = @last_name, city = @city, building = @building, street = @street WHERE UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@password", textpass.Text);
                    cmd.Parameters.AddWithValue("@email", textmail.Text);
                    cmd.Parameters.AddWithValue("@first_name", textfname.Text);
                    cmd.Parameters.AddWithValue("@last_name", textlname.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@city", textcity.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@building", textbuilding.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@street", textstreet.Text ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UID", UID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED SUCCESSFULLY");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                dataGridView1.DataSource = LoadUserTable(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private string GetValueOrNull(DataGridViewCell cell)
        {
            return cell?.Value?.ToString() ?? string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search searchf = new search();
            searchf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                if (selectedRow != null)
                {
                    textfname.Text = GetValueOrNull(selectedRow.Cells["first_name"]);
                    textlname.Text = GetValueOrNull(selectedRow.Cells["last_name"]);
                    textmail.Text = GetValueOrNull(selectedRow.Cells["email"]);
                    textpass.Text = GetValueOrNull(selectedRow.Cells["password"]);
                    textcity.Text = GetValueOrNull(selectedRow.Cells["city"]);
                    textstreet.Text = GetValueOrNull(selectedRow.Cells["street"]);
                    textbuilding.Text = GetValueOrNull(selectedRow.Cells["building"]);
                    textuid.Text = GetValueOrNull(selectedRow.Cells["UID"]);

                    string phoneNumbers = "";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["UID"].Value != null && row.Cells["UID"].Value.ToString() == textuid.Text)
                        {
                            phoneNumbers += GetValueOrNull(row.Cells["phone_number"]) + ", ";
                        }
                    }
                    textphone.Text = phoneNumbers.TrimEnd(',', ' ');
                }
            }
        }
    }

}
