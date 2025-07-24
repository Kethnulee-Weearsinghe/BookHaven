using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //to clear textboxes
            txtcustomerid.Clear();
            txtcustomernic.Clear();
            cmbtitle.SelectedIndex = -1;
            txtfirstname.Clear();
            txtlastname.Clear();
            txtcustomeremail.Clear();
            txtcustomercontactno.Clear();
            txthouseno.Clear();
            txtstreet.Clear();
            txtcity.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //to get admin dashboard form
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            AdminDashboardForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add button
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [Customer] (CustomerID, CustomerNIC, Title, FirstName, LastName, CustomerEmail, CustomerContactNo, HouseNo, Street, City) VALUES (@CustomerID, @CustomerNIC, @Title, @FirstName, @LastName, @CustomerEmail, @CustomerContactNo, @HouseNo, @Street, @City)", con);
                    cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);
                    cmd.Parameters.AddWithValue("@CustomerNIC", txtcustomernic.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@CustomerEmail", txtcustomeremail.Text);
                    cmd.Parameters.AddWithValue("@CustomerContactNo", txtcustomercontactno.Text);
                    cmd.Parameters.AddWithValue("@HouseNo", txthouseno.Text);
                    cmd.Parameters.AddWithValue("@Street", txtstreet.Text);
                    cmd.Parameters.AddWithValue("@City", txtcity.Text);

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
            //update button
            if (txtcustomerid.Text == "")
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE [Customer] SET CustomerNIC = @CustomerNIC, Title = @Title, FirstName = @FirstName, LastName = @LastName, CustomerEmail = @CustomerEmail, CustomerContactNo = @CustomerContactNo, HouseNo = HouseNo, Street = @Street, City = @City WHERE CustomerID = @CustomerID", con);
                    cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);
                    cmd.Parameters.AddWithValue("@CustomerNIC", txtcustomernic.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@CustomerEmail", txtcustomeremail.Text);
                    cmd.Parameters.AddWithValue("@CustomerContactNo", txtcustomercontactno.Text);
                    cmd.Parameters.AddWithValue("@HouseNo", txthouseno.Text);
                    cmd.Parameters.AddWithValue("@Street", txtstreet.Text);
                    cmd.Parameters.AddWithValue("@City", txtcity.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided ID.");
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
            //delete button
            if (txtcustomerid.Text == "")
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM [Customer] WHERE CustomerID = @CustomerID", con);
                        cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the provided ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'bookHavenDataSet3.Customer' table.
            this.customerTableAdapter.Fill(this.bookHavenDataSet3.Customer);

        }
    }
    
}
