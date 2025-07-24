using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookHavenDataSet5.Book' table.
            this.bookTableAdapter.Fill(this.bookHavenDataSet5.Book);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //add button
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO [Book] (BookID, BookTitle, Title, FirstName, LastName, Genre, ISBN, Price, StockQuantity, PublishedYear) VALUES (@BookID, @BookTitle, @Title, @FirstName, @LastName, @Genre, @ISBN, @Price, @StockQuantity, @PublishedYear)", con);
                    cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                    cmd.Parameters.AddWithValue("@BookTitle", txtbooktitle.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtgenre.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtisbn.Text);
                    cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@StockQuantity", nudstockquantity.Text);
                    cmd.Parameters.AddWithValue("@PublishedYear", txtpublishedyear.Text);

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
            if (txtbookid.Text == "")
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE [Book] SET BookTitle = @BookTitle, Title = @Title, FirstName = @FirstName, LastName = @LastName, Genre = @Genre, ISBN = @ISBN, Price = Price, StockQuantity = @StockQuantity, PublishedYear = @PublishedYear WHERE BookID = @BookID", con);
                    cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);
                    cmd.Parameters.AddWithValue("@BookTitle", txtbooktitle.Text);
                    cmd.Parameters.AddWithValue("@Title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtgenre.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtisbn.Text);
                    cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@StockQuantity", nudstockquantity.Text);
                    cmd.Parameters.AddWithValue("@PublishedYear", txtpublishedyear.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No book found with the provided ID.");
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
            if (txtbookid.Text == "")
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM [Book] WHERE BookID = @BookID", con);
                        cmd.Parameters.AddWithValue("@BookID", txtbookid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No book found with the provided ID.");
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
            txtbookid.Clear();
            txtbooktitle.Clear();
            cmbtitle.SelectedIndex = -1;
            txtfirstname.Clear();
            txtlastname.Clear();
            txtgenre.Clear();
            txtisbn.Clear();
            txtprice.Clear();
            nudstockquantity.Value = nudstockquantity.Minimum;
            txtpublishedyear.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //to get admin dashbaord
            AdminDashboard admindashboard = new AdminDashboard();
            admindashboard.Show();
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //to load the data on datagridview
            using (SqlConnection conn = new SqlConnection(@"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True"))
            {
                string query = "SELECT * FROM Book WHERE BookTitle LIKE @Search OR FirstName + ' ' + LastName LIKE @Search OR ISBN LIKE @Search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + txtbooktitle.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvbooks.DataSource = dt;
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbooks.Rows[e.RowIndex];

                txtbookid.Text = row.Cells["BookID"].Value.ToString();
                txtbooktitle.Text = row.Cells["BookTitle"].Value.ToString();
                cmbtitle.Text = row.Cells["Title"].Value.ToString();
                txtfirstname.Text = row.Cells["FirstName"].Value.ToString();
                txtlastname.Text = row.Cells["LastName"].Value.ToString();
                txtgenre.Text = row.Cells["Genre"].Value.ToString();
                txtisbn.Text = row.Cells["ISBN"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
                nudstockquantity.Value = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                txtpublishedyear.Text = row.Cells["PublishedYear"].Value.ToString();
            }
        }
    }
}
