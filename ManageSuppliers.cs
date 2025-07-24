using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ManageSuppliers : Form
    {
        public ManageSuppliers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //to get admin dashboard
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            AdminDashboardForm.Show();
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //add button
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [Supplier] (SupplierID, SupplierNIC, Title, FirstName, LastName, SupplierEmail, SupplierContactNo, HouseNo, Street, City) VALUES (@SupplierID, @SupplierNIC, @Title, @FirstName, @LastName, @SupplierEmail, @SupplierContactNo, @HouseNo, @Street, @City)", con);
                    cmd.Parameters.AddWithValue("@SupplierID", txtsupplierid.Text);
                    cmd.Parameters.AddWithValue("@SupplierNIC", txtsuppliernic.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@SupplierEmail", txtsupplieremail.Text);
                    cmd.Parameters.AddWithValue("@SupplierContactNo", txtsuppliercontactno.Text);
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
            if (txtsupplierid.Text == "")
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE [Supplier] SET SupplierNIC = @SupplierNIC, Title = @Title, FirstName = @FirstName, LastName = @LastName, SupplierEmail = @SupplierEmail, SupplierContactNo = @SupplierContactNo, HouseNo = HouseNo, Street = @Street, City = @City WHERE SupplierID = @SupplierID", con);
                    cmd.Parameters.AddWithValue("@SupplierID", txtsupplierid.Text);
                    cmd.Parameters.AddWithValue("@SupplierNIC", txtsuppliernic.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@SupplierEmail", txtsupplieremail.Text);
                    cmd.Parameters.AddWithValue("@SupplierContactNo", txtsuppliercontactno.Text);
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
                        MessageBox.Show("No supplier found with the provided ID.");
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
            if (txtsupplierid.Text == "")
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM [Supplier] WHERE SupplierID = @SupplierID", con);
                        cmd.Parameters.AddWithValue("@SupplierID", txtsupplierid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No supplier found with the provided ID.");
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
            //to clear textboxes
            txtsupplierid.Clear();
            txtsuppliernic.Clear();
            cmbtitle.SelectedIndex = -1;
            txtfirstname.Clear();
            txtlastname.Clear();
            txtsupplieremail.Clear();
            txtsuppliercontactno.Clear();
            txthouseno.Clear();
            txtstreet.Clear();
            txtcity.Clear();
        }

        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'bookHavenDataSet4.Supplier' table.
            this.supplierTableAdapter.Fill(this.bookHavenDataSet4.Supplier);

        }

    }
}
