using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'bookHavenDataSet17.User' table.
            this.userTableAdapter.Fill(this.bookHavenDataSet17.User);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [User] (UserID, Username, Password, Role) VALUES (@UserID, @Username, @Password, @Role)", con);
                    cmd.Parameters.AddWithValue("@UserID", txtuserid.Text);
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbrole.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text == "")
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE [User] SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID", con);
                    cmd.Parameters.AddWithValue("@UserID", txtuserid.Text);
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbrole.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text == "")
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE UserID = @UserID", con);
                        cmd.Parameters.AddWithValue("@UserID", txtuserid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the provided ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            cmbrole.SelectedIndex = -1;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            AdminDashboardForm.Show();
            this.Close();
        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
