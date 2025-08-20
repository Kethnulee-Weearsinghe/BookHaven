using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboardForm = new AdminDashboard();
            AdminDashboardForm.Show();
            this.Close();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [Inventory] (InventoryID, BookID, StockQuantity) VALUES (@InventoryID, @BookID, @StockQuantity)", con);
                    cmd.Parameters.AddWithValue("@InventoryID", txtinventoryid.Text);
                    cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                    cmd.Parameters.AddWithValue("@StockQuantity", nudstockquantity.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recorded Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)

        {
            if (txtinventoryid.Text == "")
            {
                MessageBox.Show("Please select an inventory to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE [Inventory] SET BookID = @BookID, StockQuantity = @StockQuantity WHERE InventoryID = @InventoryID", con);
                    cmd.Parameters.AddWithValue("@InventoryID", txtinventoryid.Text);
                    cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                    cmd.Parameters.AddWithValue("@StockQuantity", nudstockquantity.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No inventory found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'bookHavenDataSet1.Book' table.
            this.bookTableAdapter.Fill(this.bookHavenDataSet1.Book);
            //This line of code loads data into the 'bookHavenDataSet.Inventory' table. 
            this.inventoryTableAdapter.Fill(this.bookHavenDataSet.Inventory);

        }

        private void dgvbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
    }
}








