using System;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnmanageusers = new System.Windows.Forms.Button();
            this.btnmanagecustomers = new System.Windows.Forms.Button();
            this.btnmanagesuppliers = new System.Windows.Forms.Button();
            this.btnmanagebooks = new System.Windows.Forms.Button();
            this.btnmanageorders = new System.Windows.Forms.Button();
            this.btnviewreports = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.btnmanageusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageusers.Location = new System.Drawing.Point(80, 185);
            this.btnmanageusers.Name = "btnmanageusers";
            this.btnmanageusers.Size = new System.Drawing.Size(260, 42);
            this.btnmanageusers.TabIndex = 2;
            this.btnmanageusers.Text = "Manage Users";
            this.btnmanageusers.UseVisualStyleBackColor = true;
            this.btnmanageusers.Click += new System.EventHandler(this.button1_Click_1);
 
            this.btnmanagecustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagecustomers.Location = new System.Drawing.Point(395, 185);
            this.btnmanagecustomers.Name = "btnmanagecustomers";
            this.btnmanagecustomers.Size = new System.Drawing.Size(260, 42);
            this.btnmanagecustomers.TabIndex = 3;
            this.btnmanagecustomers.Text = "Manage Customers";
            this.btnmanagecustomers.UseVisualStyleBackColor = true;
            this.btnmanagecustomers.Click += new System.EventHandler(this.button2_Click_1);

            this.btnmanagesuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagesuppliers.Location = new System.Drawing.Point(712, 185);
            this.btnmanagesuppliers.Name = "btnmanagesuppliers";
            this.btnmanagesuppliers.Size = new System.Drawing.Size(260, 42);
            this.btnmanagesuppliers.TabIndex = 4;
            this.btnmanagesuppliers.Text = "Manage Suppliers";
            this.btnmanagesuppliers.UseVisualStyleBackColor = true;
            this.btnmanagesuppliers.Click += new System.EventHandler(this.button3_Click_1);

            this.btnmanagebooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagebooks.Location = new System.Drawing.Point(80, 257);
            this.btnmanagebooks.Name = "btnmanagebooks";
            this.btnmanagebooks.Size = new System.Drawing.Size(260, 42);
            this.btnmanagebooks.TabIndex = 5;
            this.btnmanagebooks.Text = "Manage Books";
            this.btnmanagebooks.UseVisualStyleBackColor = true;
            this.btnmanagebooks.Click += new System.EventHandler(this.button4_Click_1);

            this.btnmanageorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageorders.Location = new System.Drawing.Point(395, 257);
            this.btnmanageorders.Name = "btnmanageorders";
            this.btnmanageorders.Size = new System.Drawing.Size(260, 42);
            this.btnmanageorders.TabIndex = 6;
            this.btnmanageorders.Text = "Manage Orders";
            this.btnmanageorders.UseVisualStyleBackColor = true;
            this.btnmanageorders.Click += new System.EventHandler(this.button5_Click_1);

            this.btnviewreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewreports.Location = new System.Drawing.Point(712, 257);
            this.btnviewreports.Name = "btnviewreports";
            this.btnviewreports.Size = new System.Drawing.Size(260, 42);
            this.btnviewreports.TabIndex = 7;
            this.btnviewreports.Text = "View Reports";
            this.btnviewreports.UseVisualStyleBackColor = true;
            this.btnviewreports.Click += new System.EventHandler(this.button6_Click_1);

            this.btninventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory.Location = new System.Drawing.Point(395, 324);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(260, 42);
            this.btninventory.TabIndex = 8;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = true;
            this.btninventory.Click += new System.EventHandler(this.button7_Click_1);

            this.btnlogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Location = new System.Drawing.Point(952, 384);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(60, 28);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button8_Click_1);

            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.btnviewreports);
            this.Controls.Add(this.btnmanageorders);
            this.Controls.Add(this.btnmanagebooks);
            this.Controls.Add(this.btnmanagesuppliers);
            this.Controls.Add(this.btnmanagecustomers);
            this.Controls.Add(this.btnmanageusers);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);

        }

        private Button btnmanageusers;
        private Button btnmanagecustomers;
        private Button btnmanagesuppliers;
        private Button btnmanagebooks;
        private Button btnmanageorders;
        private Button btnviewreports;
        private Button btninventory;
        private Button btnlogout;

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManageUsers ManageUsersForm = new ManageUsers();
            ManageUsersForm.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageCustomers ManageCustomersForm = new ManageCustomers();
            ManageCustomersForm.Show();
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ManageBooks ManageBookForm = new ManageBooks();
            ManageBookForm.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManageSuppliers ManageSuppliersForm = new ManageSuppliers();
            ManageSuppliersForm.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ManageOrders ManageOrdersForm = new ManageOrders();
            ManageOrdersForm.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ViewReports ViewReportsForm = new ViewReports();
            ViewReportsForm.Show();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Inventory InventoryForm = new Inventory();
            InventoryForm.Show();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Close();
        }
    }
}


