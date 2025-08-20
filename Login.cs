using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
      
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            using (SqlConnection conn = DBConnection.GetConnection())

            {
                try
                {
                    conn.Open();

                    string query = "SELECT Role FROM [User] WHERE Username = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            MessageBox.Show("Login successful!" + role);
                            if (role.Trim().ToLower() == "admin")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                                this.Hide();
                            }

                            else if (role == "Salesclerk")
                            {
                                SalesclerkDashboard salesclerkDashboard = new SalesclerkDashboard();
                                salesclerkDashboard.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed:\n" + ex.Message);
                }
            }
        }


    }

}



