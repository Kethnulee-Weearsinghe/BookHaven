namespace BookHaven
{
    partial class ManageSuppliers
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
            this.managesupplier = new System.Windows.Forms.Label();
            this.gbsupplieraddress = new System.Windows.Forms.GroupBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txthouseno = new System.Windows.Forms.TextBox();
            this.houseno = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.txtsupplieremail = new System.Windows.Forms.TextBox();
            this.supplieremail = new System.Windows.Forms.Label();
            this.gbsuppliername = new System.Windows.Forms.GroupBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.cmbtitle = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.txtsuppliernic = new System.Windows.Forms.TextBox();
            this.suppliernic = new System.Windows.Forms.Label();
            this.txtsupplierid = new System.Windows.Forms.TextBox();
            this.supplierid = new System.Windows.Forms.Label();
            this.txtsuppliercontactno = new System.Windows.Forms.TextBox();
            this.suppliercontactno = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvsuppliers = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet4 = new BookHaven.BookHavenDataSet4();
            this.btnback = new System.Windows.Forms.Button();
            this.supplierTableAdapter = new BookHaven.BookHavenDataSet4TableAdapters.SupplierTableAdapter();
            this.gbsupplieraddress.SuspendLayout();
            this.gbsuppliername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // managesupplier
            // 
            this.managesupplier.AutoSize = true;
            this.managesupplier.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managesupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.managesupplier.Location = new System.Drawing.Point(389, 28);
            this.managesupplier.Name = "managesupplier";
            this.managesupplier.Size = new System.Drawing.Size(233, 36);
            this.managesupplier.TabIndex = 44;
            this.managesupplier.Text = "Manage Suppliers";
            // 
            // gbsupplieraddress
            // 
            this.gbsupplieraddress.Controls.Add(this.txtcity);
            this.gbsupplieraddress.Controls.Add(this.txthouseno);
            this.gbsupplieraddress.Controls.Add(this.houseno);
            this.gbsupplieraddress.Controls.Add(this.txtstreet);
            this.gbsupplieraddress.Controls.Add(this.street);
            this.gbsupplieraddress.Controls.Add(this.city);
            this.gbsupplieraddress.ForeColor = System.Drawing.SystemColors.Control;
            this.gbsupplieraddress.Location = new System.Drawing.Point(371, 218);
            this.gbsupplieraddress.Name = "gbsupplieraddress";
            this.gbsupplieraddress.Size = new System.Drawing.Size(281, 139);
            this.gbsupplieraddress.TabIndex = 37;
            this.gbsupplieraddress.TabStop = false;
            this.gbsupplieraddress.Text = "Supplier Address";
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
            // txtsupplieremail
            // 
            this.txtsupplieremail.Location = new System.Drawing.Point(516, 133);
            this.txtsupplieremail.Name = "txtsupplieremail";
            this.txtsupplieremail.Size = new System.Drawing.Size(136, 20);
            this.txtsupplieremail.TabIndex = 38;
            // 
            // supplieremail
            // 
            this.supplieremail.AutoSize = true;
            this.supplieremail.ForeColor = System.Drawing.SystemColors.Control;
            this.supplieremail.Location = new System.Drawing.Point(378, 136);
            this.supplieremail.Name = "supplieremail";
            this.supplieremail.Size = new System.Drawing.Size(73, 13);
            this.supplieremail.TabIndex = 39;
            this.supplieremail.Text = "Supplier Email";
            // 
            // gbsuppliername
            // 
            this.gbsuppliername.Controls.Add(this.txtlastname);
            this.gbsuppliername.Controls.Add(this.lastname);
            this.gbsuppliername.Controls.Add(this.txtfirstname);
            this.gbsuppliername.Controls.Add(this.firstname);
            this.gbsuppliername.Controls.Add(this.cmbtitle);
            this.gbsuppliername.Controls.Add(this.title);
            this.gbsuppliername.ForeColor = System.Drawing.SystemColors.Control;
            this.gbsuppliername.Location = new System.Drawing.Point(53, 211);
            this.gbsuppliername.Name = "gbsuppliername";
            this.gbsuppliername.Size = new System.Drawing.Size(281, 146);
            this.gbsuppliername.TabIndex = 36;
            this.gbsuppliername.TabStop = false;
            this.gbsuppliername.Text = "Supplier Name";
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
            // txtsuppliernic
            // 
            this.txtsuppliernic.Location = new System.Drawing.Point(150, 168);
            this.txtsuppliernic.Name = "txtsuppliernic";
            this.txtsuppliernic.Size = new System.Drawing.Size(100, 20);
            this.txtsuppliernic.TabIndex = 35;
            // 
            // suppliernic
            // 
            this.suppliernic.AutoSize = true;
            this.suppliernic.ForeColor = System.Drawing.SystemColors.Control;
            this.suppliernic.Location = new System.Drawing.Point(60, 171);
            this.suppliernic.Name = "suppliernic";
            this.suppliernic.Size = new System.Drawing.Size(66, 13);
            this.suppliernic.TabIndex = 34;
            this.suppliernic.Text = "Supplier NIC";
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.Location = new System.Drawing.Point(150, 129);
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(100, 20);
            this.txtsupplierid.TabIndex = 33;
            // 
            // supplierid
            // 
            this.supplierid.AutoSize = true;
            this.supplierid.ForeColor = System.Drawing.SystemColors.Control;
            this.supplierid.Location = new System.Drawing.Point(60, 132);
            this.supplierid.Name = "supplierid";
            this.supplierid.Size = new System.Drawing.Size(59, 13);
            this.supplierid.TabIndex = 32;
            this.supplierid.Text = "Supplier ID";
            // 
            // txtsuppliercontactno
            // 
            this.txtsuppliercontactno.Location = new System.Drawing.Point(516, 171);
            this.txtsuppliercontactno.Name = "txtsuppliercontactno";
            this.txtsuppliercontactno.Size = new System.Drawing.Size(136, 20);
            this.txtsuppliercontactno.TabIndex = 45;
            // 
            // suppliercontactno
            // 
            this.suppliercontactno.AutoSize = true;
            this.suppliercontactno.ForeColor = System.Drawing.SystemColors.Control;
            this.suppliercontactno.Location = new System.Drawing.Point(378, 178);
            this.suppliercontactno.Name = "suppliercontactno";
            this.suppliercontactno.Size = new System.Drawing.Size(102, 13);
            this.suppliercontactno.TabIndex = 46;
            this.suppliercontactno.Text = "Supplier Contact No";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(405, 416);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 83;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(277, 416);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 81;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(165, 416);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 80;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(53, 416);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 79;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvsuppliers
            // 
            this.dgvsuppliers.AllowUserToOrderColumns = true;
            this.dgvsuppliers.AutoGenerateColumns = false;
            this.dgvsuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNICDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierContactNoDataGridViewTextBoxColumn,
            this.houseNoDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgvsuppliers.DataSource = this.supplierBindingSource;
            this.dgvsuppliers.Location = new System.Drawing.Point(699, 120);
            this.dgvsuppliers.Name = "dgvsuppliers";
            this.dgvsuppliers.Size = new System.Drawing.Size(340, 237);
            this.dgvsuppliers.TabIndex = 84;
            this.dgvsuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // supplierNICDataGridViewTextBoxColumn
            // 
            this.supplierNICDataGridViewTextBoxColumn.DataPropertyName = "SupplierNIC";
            this.supplierNICDataGridViewTextBoxColumn.HeaderText = "SupplierNIC";
            this.supplierNICDataGridViewTextBoxColumn.Name = "supplierNICDataGridViewTextBoxColumn";
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
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "SupplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            // 
            // supplierContactNoDataGridViewTextBoxColumn
            // 
            this.supplierContactNoDataGridViewTextBoxColumn.DataPropertyName = "SupplierContactNo";
            this.supplierContactNoDataGridViewTextBoxColumn.HeaderText = "SupplierContactNo";
            this.supplierContactNoDataGridViewTextBoxColumn.Name = "supplierContactNoDataGridViewTextBoxColumn";
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
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.bookHavenDataSet4;
            // 
            // bookHavenDataSet4
            // 
            this.bookHavenDataSet4.DataSetName = "BookHavenDataSet4";
            this.bookHavenDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(979, 452);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 28);
            this.btnback.TabIndex = 85;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button5_Click);
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvsuppliers);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.suppliercontactno);
            this.Controls.Add(this.txtsuppliercontactno);
            this.Controls.Add(this.managesupplier);
            this.Controls.Add(this.gbsupplieraddress);
            this.Controls.Add(this.txtsupplieremail);
            this.Controls.Add(this.supplieremail);
            this.Controls.Add(this.gbsuppliername);
            this.Controls.Add(this.txtsuppliernic);
            this.Controls.Add(this.suppliernic);
            this.Controls.Add(this.txtsupplierid);
            this.Controls.Add(this.supplierid);
            this.Name = "ManageSuppliers";
            this.Text = "Manage Suppliers";
            this.Load += new System.EventHandler(this.ManageSuppliers_Load);
            this.gbsupplieraddress.ResumeLayout(false);
            this.gbsupplieraddress.PerformLayout();
            this.gbsuppliername.ResumeLayout(false);
            this.gbsuppliername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managesupplier;
        private System.Windows.Forms.GroupBox gbsupplieraddress;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txthouseno;
        private System.Windows.Forms.Label houseno;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox txtsupplieremail;
        private System.Windows.Forms.Label supplieremail;
        private System.Windows.Forms.GroupBox gbsuppliername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.ComboBox cmbtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtsuppliernic;
        private System.Windows.Forms.Label suppliernic;
        private System.Windows.Forms.TextBox txtsupplierid;
        private System.Windows.Forms.Label supplierid;
        private System.Windows.Forms.TextBox txtsuppliercontactno;
        private System.Windows.Forms.Label suppliercontactno;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvsuppliers;
        private System.Windows.Forms.Button btnback;
        private BookHavenDataSet4 bookHavenDataSet4;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private BookHavenDataSet4TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}