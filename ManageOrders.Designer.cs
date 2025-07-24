namespace BookHaven
{
    partial class ManageOrders
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
            this.customerid = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.Label();
            this.orderstatus = new System.Windows.Forms.Label();
            this.cmborderstatus = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvorders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet6 = new BookHaven.BookHavenDataSet6();
            this.btnback = new System.Windows.Forms.Button();
            this.manageorder = new System.Windows.Forms.Label();
            this.orderid = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.dtporderdate = new System.Windows.Forms.DateTimePicker();
            this.btnclear = new System.Windows.Forms.Button();
            this.totalamount = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.rbpickup = new System.Windows.Forms.RadioButton();
            this.rbdelivery = new System.Windows.Forms.RadioButton();
            this.gbdeliverymethodd = new System.Windows.Forms.GroupBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.ordersTableAdapter = new BookHaven.BookHavenDataSet6TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet6)).BeginInit();
            this.gbdeliverymethodd.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.ForeColor = System.Drawing.SystemColors.Control;
            this.customerid.Location = new System.Drawing.Point(68, 153);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(65, 13);
            this.customerid.TabIndex = 0;
            this.customerid.Text = "Customer ID";
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.ForeColor = System.Drawing.SystemColors.Control;
            this.bookid.Location = new System.Drawing.Point(68, 197);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(46, 13);
            this.bookid.TabIndex = 3;
            this.bookid.Text = "Book ID";
            // 
            // orderdate
            // 
            this.orderdate.AutoSize = true;
            this.orderdate.ForeColor = System.Drawing.SystemColors.Control;
            this.orderdate.Location = new System.Drawing.Point(69, 236);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(59, 13);
            this.orderdate.TabIndex = 4;
            this.orderdate.Text = "Order Date";
            // 
            // orderstatus
            // 
            this.orderstatus.AutoSize = true;
            this.orderstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.orderstatus.Location = new System.Drawing.Point(350, 116);
            this.orderstatus.Name = "orderstatus";
            this.orderstatus.Size = new System.Drawing.Size(66, 13);
            this.orderstatus.TabIndex = 6;
            this.orderstatus.Text = "Order Status";
            this.orderstatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmborderstatus
            // 
            this.cmborderstatus.FormattingEnabled = true;
            this.cmborderstatus.Items.AddRange(new object[] {
            "Pending",
            "Delivered",
            "Canceled"});
            this.cmborderstatus.Location = new System.Drawing.Point(485, 113);
            this.cmborderstatus.Name = "cmborderstatus";
            this.cmborderstatus.Size = new System.Drawing.Size(152, 21);
            this.cmborderstatus.TabIndex = 7;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(291, 416);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 77;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(179, 416);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 76;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(67, 416);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 75;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvorders
            // 
            this.dgvorders.AllowUserToOrderColumns = true;
            this.dgvorders.AutoGenerateColumns = false;
            this.dgvorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.deliveryMethodDataGridViewTextBoxColumn});
            this.dgvorders.DataSource = this.ordersBindingSource;
            this.dgvorders.Location = new System.Drawing.Point(681, 104);
            this.dgvorders.Name = "dgvorders";
            this.dgvorders.Size = new System.Drawing.Size(342, 241);
            this.dgvorders.TabIndex = 80;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // deliveryMethodDataGridViewTextBoxColumn
            // 
            this.deliveryMethodDataGridViewTextBoxColumn.DataPropertyName = "DeliveryMethod";
            this.deliveryMethodDataGridViewTextBoxColumn.HeaderText = "DeliveryMethod";
            this.deliveryMethodDataGridViewTextBoxColumn.Name = "deliveryMethodDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bookHavenDataSet6;
            // 
            // bookHavenDataSet6
            // 
            this.bookHavenDataSet6.DataSetName = "BookHavenDataSet6";
            this.bookHavenDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(963, 446);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 28);
            this.btnback.TabIndex = 81;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button5_Click);
            // 
            // manageorder
            // 
            this.manageorder.AutoSize = true;
            this.manageorder.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageorder.ForeColor = System.Drawing.SystemColors.Control;
            this.manageorder.Location = new System.Drawing.Point(451, 27);
            this.manageorder.Name = "manageorder";
            this.manageorder.Size = new System.Drawing.Size(203, 36);
            this.manageorder.TabIndex = 82;
            this.manageorder.Text = "Manage Orders";
            this.manageorder.Click += new System.EventHandler(this.label5_Click);
            // 
            // orderid
            // 
            this.orderid.AutoSize = true;
            this.orderid.ForeColor = System.Drawing.SystemColors.Control;
            this.orderid.Location = new System.Drawing.Point(68, 119);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(47, 13);
            this.orderid.TabIndex = 83;
            this.orderid.Text = "Order ID";
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(202, 116);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(100, 20);
            this.txtorderid.TabIndex = 84;
            // 
            // dtporderdate
            // 
            this.dtporderdate.Location = new System.Drawing.Point(201, 230);
            this.dtporderdate.Name = "dtporderdate";
            this.dtporderdate.Size = new System.Drawing.Size(187, 20);
            this.dtporderdate.TabIndex = 85;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(403, 416);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 86;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.ForeColor = System.Drawing.SystemColors.Control;
            this.totalamount.Location = new System.Drawing.Point(350, 158);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(70, 13);
            this.totalamount.TabIndex = 87;
            this.totalamount.Text = "Total Amount";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(202, 150);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(100, 20);
            this.txtcustomerid.TabIndex = 88;
            // 
            // rbpickup
            // 
            this.rbpickup.AutoSize = true;
            this.rbpickup.ForeColor = System.Drawing.SystemColors.Control;
            this.rbpickup.Location = new System.Drawing.Point(19, 22);
            this.rbpickup.Name = "rbpickup";
            this.rbpickup.Size = new System.Drawing.Size(58, 17);
            this.rbpickup.TabIndex = 89;
            this.rbpickup.TabStop = true;
            this.rbpickup.Text = "Pickup";
            this.rbpickup.UseVisualStyleBackColor = true;
            // 
            // rbdelivery
            // 
            this.rbdelivery.AutoSize = true;
            this.rbdelivery.ForeColor = System.Drawing.SystemColors.Control;
            this.rbdelivery.Location = new System.Drawing.Point(19, 55);
            this.rbdelivery.Name = "rbdelivery";
            this.rbdelivery.Size = new System.Drawing.Size(63, 17);
            this.rbdelivery.TabIndex = 90;
            this.rbdelivery.TabStop = true;
            this.rbdelivery.Text = "Delivery";
            this.rbdelivery.UseVisualStyleBackColor = true;
            // 
            // gbdeliverymethodd
            // 
            this.gbdeliverymethodd.Controls.Add(this.rbdelivery);
            this.gbdeliverymethodd.Controls.Add(this.rbpickup);
            this.gbdeliverymethodd.ForeColor = System.Drawing.SystemColors.Control;
            this.gbdeliverymethodd.Location = new System.Drawing.Point(437, 197);
            this.gbdeliverymethodd.Name = "gbdeliverymethodd";
            this.gbdeliverymethodd.Size = new System.Drawing.Size(200, 100);
            this.gbdeliverymethodd.TabIndex = 91;
            this.gbdeliverymethodd.TabStop = false;
            this.gbdeliverymethodd.Text = "Delivery Method";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(201, 190);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(101, 20);
            this.txtbookid.TabIndex = 92;
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(485, 155);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(92, 20);
            this.txttotalamount.TabIndex = 93;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.gbdeliverymethodd);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dtporderdate);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.orderid);
            this.Controls.Add(this.manageorder);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvorders);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmborderstatus);
            this.Controls.Add(this.orderstatus);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.customerid);
            this.Name = "ManageOrders";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet6)).EndInit();
            this.gbdeliverymethodd.ResumeLayout(false);
            this.gbdeliverymethodd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Label orderdate;
        private System.Windows.Forms.Label orderstatus;
        private System.Windows.Forms.ComboBox cmborderstatus;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvorders;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label manageorder;
        private System.Windows.Forms.Label orderid;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.DateTimePicker dtporderdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.RadioButton rbpickup;
        private System.Windows.Forms.RadioButton rbdelivery;
        private System.Windows.Forms.GroupBox gbdeliverymethodd;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txttotalamount;
        private BookHavenDataSet6 bookHavenDataSet6;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BookHavenDataSet6TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryMethodDataGridViewTextBoxColumn;
    }
}