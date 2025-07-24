namespace BookHaven
{
    partial class ManageCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customercontactno = new System.Windows.Forms.Label();
            this.txtcustomercontactno = new System.Windows.Forms.TextBox();
            this.managecustomer = new System.Windows.Forms.Label();
            this.gbcustomeraddress = new System.Windows.Forms.GroupBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txthouseno = new System.Windows.Forms.TextBox();
            this.houseno = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.txtcustomeremail = new System.Windows.Forms.TextBox();
            this.customeremail = new System.Windows.Forms.Label();
            this.gbcustomername = new System.Windows.Forms.GroupBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.cmbtitle = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.txtcustomernic = new System.Windows.Forms.TextBox();
            this.customernic = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvcustomers = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet3 = new BookHaven.BookHavenDataSet3();
            this.btnback = new System.Windows.Forms.Button();
            this.customerTableAdapter = new BookHaven.BookHavenDataSet3TableAdapters.CustomerTableAdapter();
            this.gbcustomeraddress.SuspendLayout();
            this.gbcustomername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // customercontactno
            // 
            this.customercontactno.AutoSize = true;
            this.customercontactno.ForeColor = System.Drawing.SystemColors.Control;
            this.customercontactno.Location = new System.Drawing.Point(386, 178);
            this.customercontactno.Name = "customercontactno";
            this.customercontactno.Size = new System.Drawing.Size(108, 13);
            this.customercontactno.TabIndex = 61;
            this.customercontactno.Text = "Customer Contact No";
            // 
            // txtcustomercontactno
            // 
            this.txtcustomercontactno.Location = new System.Drawing.Point(524, 171);
            this.txtcustomercontactno.Name = "txtcustomercontactno";
            this.txtcustomercontactno.Size = new System.Drawing.Size(136, 20);
            this.txtcustomercontactno.TabIndex = 60;
            // 
            // managecustomer
            // 
            this.managecustomer.AutoSize = true;
            this.managecustomer.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managecustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.managecustomer.Location = new System.Drawing.Point(383, 33);
            this.managecustomer.Name = "managecustomer";
            this.managecustomer.Size = new System.Drawing.Size(250, 36);
            this.managecustomer.TabIndex = 59;
            this.managecustomer.Text = "Manage Customers";
            // 
            // gbcustomeraddress
            // 
            this.gbcustomeraddress.Controls.Add(this.txtcity);
            this.gbcustomeraddress.Controls.Add(this.txthouseno);
            this.gbcustomeraddress.Controls.Add(this.houseno);
            this.gbcustomeraddress.Controls.Add(this.txtstreet);
            this.gbcustomeraddress.Controls.Add(this.street);
            this.gbcustomeraddress.Controls.Add(this.city);
            this.gbcustomeraddress.ForeColor = System.Drawing.SystemColors.Control;
            this.gbcustomeraddress.Location = new System.Drawing.Point(379, 218);
            this.gbcustomeraddress.Name = "gbcustomeraddress";
            this.gbcustomeraddress.Size = new System.Drawing.Size(281, 139);
            this.gbcustomeraddress.TabIndex = 52;
            this.gbcustomeraddress.TabStop = false;
            this.gbcustomeraddress.Text = "Customer Address";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(90, 100);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(161, 20);
            this.txtcity.TabIndex = 11;
            // 
            // txthouseno
            // 
            this.txthouseno.Location = new System.Drawing.Point(90, 26);
            this.txthouseno.Name = "txthouseno";
            this.txthouseno.Size = new System.Drawing.Size(78, 20);
            this.txthouseno.TabIndex = 10;
            // 
            // houseno
            // 
            this.houseno.AutoSize = true;
            this.houseno.Location = new System.Drawing.Point(8, 29);
            this.houseno.Name = "houseno";
            this.houseno.Size = new System.Drawing.Size(55, 13);
            this.houseno.TabIndex = 9;
            this.houseno.Text = "House No";
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(90, 63);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(161, 20);
            this.txtstreet.TabIndex = 7;
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(8, 66);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(35, 13);
            this.street.TabIndex = 8;
            this.street.Text = "Street";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(8, 103);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 7;
            this.city.Text = "City";
            // 
            // txtcustomeremail
            // 
            this.txtcustomeremail.Location = new System.Drawing.Point(524, 133);
            this.txtcustomeremail.Name = "txtcustomeremail";
            this.txtcustomeremail.Size = new System.Drawing.Size(136, 20);
            this.txtcustomeremail.TabIndex = 53;
            // 
            // customeremail
            // 
            this.customeremail.AutoSize = true;
            this.customeremail.ForeColor = System.Drawing.SystemColors.Control;
            this.customeremail.Location = new System.Drawing.Point(386, 136);
            this.customeremail.Name = "customeremail";
            this.customeremail.Size = new System.Drawing.Size(79, 13);
            this.customeremail.TabIndex = 54;
            this.customeremail.Text = "Customer Email";
            // 
            // gbcustomername
            // 
            this.gbcustomername.Controls.Add(this.txtlastname);
            this.gbcustomername.Controls.Add(this.lastname);
            this.gbcustomername.Controls.Add(this.txtfirstname);
            this.gbcustomername.Controls.Add(this.firstname);
            this.gbcustomername.Controls.Add(this.cmbtitle);
            this.gbcustomername.Controls.Add(this.title);
            this.gbcustomername.ForeColor = System.Drawing.SystemColors.Control;
            this.gbcustomername.Location = new System.Drawing.Point(53, 211);
            this.gbcustomername.Name = "gbcustomername";
            this.gbcustomername.Size = new System.Drawing.Size(281, 146);
            this.gbcustomername.TabIndex = 51;
            this.gbcustomername.TabStop = false;
            this.gbcustomername.Text = "Customer Name";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(96, 100);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(161, 20);
            this.txtlastname.TabIndex = 10;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(8, 103);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(58, 13);
            this.lastname.TabIndex = 9;
            this.lastname.Text = "Last Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(96, 63);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(161, 20);
            this.txtfirstname.TabIndex = 7;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(8, 70);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(57, 13);
            this.firstname.TabIndex = 8;
            this.firstname.Text = "First Name";
            // 
            // cmbtitle
            // 
            this.cmbtitle.FormattingEnabled = true;
            this.cmbtitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms."});
            this.cmbtitle.Location = new System.Drawing.Point(96, 28);
            this.cmbtitle.Name = "cmbtitle";
            this.cmbtitle.Size = new System.Drawing.Size(79, 21);
            this.cmbtitle.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(8, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 7;
            this.title.Text = "Title";
            // 
            // txtcustomernic
            // 
            this.txtcustomernic.Location = new System.Drawing.Point(150, 168);
            this.txtcustomernic.Name = "txtcustomernic";
            this.txtcustomernic.Size = new System.Drawing.Size(100, 20);
            this.txtcustomernic.TabIndex = 50;
            // 
            // customernic
            // 
            this.customernic.AutoSize = true;
            this.customernic.ForeColor = System.Drawing.SystemColors.Control;
            this.customernic.Location = new System.Drawing.Point(60, 171);
            this.customernic.Name = "customernic";
            this.customernic.Size = new System.Drawing.Size(72, 13);
            this.customernic.TabIndex = 49;
            this.customernic.Text = "Customer NIC";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(150, 129);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(100, 20);
            this.txtcustomerid.TabIndex = 48;
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.ForeColor = System.Drawing.SystemColors.Control;
            this.customerid.Location = new System.Drawing.Point(60, 132);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(65, 13);
            this.customerid.TabIndex = 47;
            this.customerid.Text = "Customer ID";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(390, 417);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 82;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(277, 417);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 81;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(165, 417);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 80;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(53, 417);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 79;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvcustomers
            // 
            this.dgvcustomers.AllowUserToOrderColumns = true;
            this.dgvcustomers.AutoGenerateColumns = false;
            this.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNICDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerContactNoDataGridViewTextBoxColumn,
            this.houseNoDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgvcustomers.DataSource = this.customerBindingSource;
            this.dgvcustomers.Location = new System.Drawing.Point(699, 97);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.Size = new System.Drawing.Size(343, 260);
            this.dgvcustomers.TabIndex = 84;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerNICDataGridViewTextBoxColumn
            // 
            this.customerNICDataGridViewTextBoxColumn.DataPropertyName = "CustomerNIC";
            this.customerNICDataGridViewTextBoxColumn.HeaderText = "CustomerNIC";
            this.customerNICDataGridViewTextBoxColumn.Name = "customerNICDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // customerContactNoDataGridViewTextBoxColumn
            // 
            this.customerContactNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerContactNo";
            this.customerContactNoDataGridViewTextBoxColumn.HeaderText = "CustomerContactNo";
            this.customerContactNoDataGridViewTextBoxColumn.Name = "customerContactNoDataGridViewTextBoxColumn";
            // 
            // houseNoDataGridViewTextBoxColumn
            // 
            this.houseNoDataGridViewTextBoxColumn.DataPropertyName = "HouseNo";
            this.houseNoDataGridViewTextBoxColumn.HeaderText = "HouseNo";
            this.houseNoDataGridViewTextBoxColumn.Name = "houseNoDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bookHavenDataSet3;
            // 
            // bookHavenDataSet3
            // 
            this.bookHavenDataSet3.DataSetName = "BookHavenDataSet3";
            this.bookHavenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(982, 451);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 28);
            this.btnback.TabIndex = 85;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button5_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvcustomers);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.customercontactno);
            this.Controls.Add(this.txtcustomercontactno);
            this.Controls.Add(this.managecustomer);
            this.Controls.Add(this.gbcustomeraddress);
            this.Controls.Add(this.txtcustomeremail);
            this.Controls.Add(this.customeremail);
            this.Controls.Add(this.gbcustomername);
            this.Controls.Add(this.txtcustomernic);
            this.Controls.Add(this.customernic);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.customerid);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.gbcustomeraddress.ResumeLayout(false);
            this.gbcustomeraddress.PerformLayout();
            this.gbcustomername.ResumeLayout(false);
            this.gbcustomername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customercontactno;
        private System.Windows.Forms.TextBox txtcustomercontactno;
        private System.Windows.Forms.Label managecustomer;
        private System.Windows.Forms.GroupBox gbcustomeraddress;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txthouseno;
        private System.Windows.Forms.Label houseno;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox txtcustomeremail;
        private System.Windows.Forms.Label customeremail;
        private System.Windows.Forms.GroupBox gbcustomername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.ComboBox cmbtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtcustomernic;
        private System.Windows.Forms.Label customernic;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvcustomers;
        private System.Windows.Forms.Button btnback;
        private BookHavenDataSet3 bookHavenDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BookHavenDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}