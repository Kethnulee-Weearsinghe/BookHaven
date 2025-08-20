using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            AdminDashboardForm.Show();
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [Orders] (OrderID, CustomerID, BookID, OrderDate, OrderStatus, TotalAmount) VALUES (@OrderID, @CustomerID, @BookID, @OrderDate, @OrderStatus, @TotalAmount)", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", txtorderid.Text);
                        cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);
                        cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                        cmd.Parameters.AddWithValue("@OrderDate", dtporderdate.Value);
                        cmd.Parameters.AddWithValue("@OrderStatus", cmborderstatus.Text);
                        cmd.Parameters.AddWithValue("@TotalAmount", txttotalamount.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtorderid.Text == "")
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE [Orders] SET CustomerID = @CustomerID, BookID = @BookID, OrderDate = @OrderDate, OrderStatus = @OrderStatus, TotalAmount = @TotalAmount WHERE OrderID = @OrderID", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", txtorderid.Text);
                        cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);
                        cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                        cmd.Parameters.AddWithValue("@OrderDate", dtporderdate.Value);
                        cmd.Parameters.AddWithValue("@OrderStatus", cmborderstatus.Text);
                        cmd.Parameters.AddWithValue("@TotalAmount", txttotalamount.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No order found with the provided ID.");
                        }
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
            if (txtorderid.Text == "")
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM [Orders] WHERE OrderID = @OrderID", con))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", txtorderid.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No order found with the provided ID.");
                            }
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
            txtorderid.Clear();
            txtcustomerid.Clear();
            txtbookid.Clear();
            dtporderdate.Value = DateTime.Now;
            cmborderstatus.SelectedIndex = -1;
            txttotalamount.Clear();
            rbpickup.Checked = false;
            rbdelivery.Checked = false;

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'bookHavenDataSet3.Customer' table.
            this.ordersTableAdapter.Fill(this.bookHavenDataSet6.Orders);

        }

    }
}

           


