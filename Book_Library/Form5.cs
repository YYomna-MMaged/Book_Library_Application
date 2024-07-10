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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtmajor_TextChanged(object sender, EventArgs e)
        {

        }
        static string sql = "Data Source=DESKTOP-LFP5QI4;Initial Catalog=PROJECT;Integrated Security=True;Encrypt=False";
       // SqlConnection con = new SqlConnection(sql);
        private void btnsignup_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection(sql))
            {
                try
                {

                    int uid = int.Parse(txtuid.Text);

                    string userQuery = "INSERT INTO [USER] ([password], [email], [first_name], [last_name], [city], [street], [UID]) VALUES (@Password, @Email, @FirstName, @LastName, @City, @Street, @UID)";
                    string studentQuery = "INSERT INTO [student] ([UID], [graduation_year], [major]) VALUES (@UID, @GraduationYear, @Major)";
                    string adminQuery = "INSERT INTO [ADMIN] ([UID] , [salary]) VALUES (@UID , 0)";
                    using (SqlCommand cmd = new SqlCommand(userQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                        cmd.Parameters.AddWithValue("@City", txtcity.Text);
                        cmd.Parameters.AddWithValue("@Street", txtstreet.Text);
                        cmd.Parameters.AddWithValue("@UID", uid);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    if (cmbregisteras.SelectedIndex == 0)
                    {
                        using (SqlCommand studentCmd = new SqlCommand(studentQuery, con))
                        {
                            studentCmd.Parameters.AddWithValue("@UID", uid);
                            studentCmd.Parameters.AddWithValue("@GraduationYear", txtgyear.Text);
                            studentCmd.Parameters.AddWithValue("@Major", txtmajor.Text);

                            studentCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand adCmd = new SqlCommand(adminQuery, con))
                        {
                            adCmd.Parameters.AddWithValue("@UID", uid);
                            adCmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    MessageBox.Show("Register Successfully");
                    Form1 form1 = new Form1(cmbregisteras.SelectedItem.ToString());
                    form1.Show();
                    this.Hide();

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid numeric values for UID and Graduation Year.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while registering: " + ex.Message);

                }
            }

        //    string text = ((cmbregisteras)comboBox.SelectedItem).Content.ToString();
        


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
