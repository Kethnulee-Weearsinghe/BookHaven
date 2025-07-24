namespace BookHaven
{
    partial class Inventory
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
            this.dgvinventory = new System.Windows.Forms.DataGridView();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet = new BookHaven.BookHavenDataSet();
            this.inventoryid = new System.Windows.Forms.Label();
            this.txtinventoryid = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.stockquantity = new System.Windows.Forms.Label();
            this.nudstockquantity = new System.Windows.Forms.NumericUpDown();
            this.btnrecord = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.inventor = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.inventoryTableAdapter = new BookHaven.BookHavenDataSetTableAdapters.InventoryTableAdapter();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet1 = new BookHaven.BookHavenDataSet1();
            this.bookHavenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BookHaven.BookHavenDataSet1TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinventory
            // 
            this.dgvinventory.AllowUserToOrderColumns = true;
            this.dgvinventory.AutoGenerateColumns = false;
            this.dgvinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dgvinventory.DataSource = this.inventoryBindingSource;
            this.dgvinventory.Location = new System.Drawing.Point(686, 127);
            this.dgvinventory.Name = "dgvinventory";
            this.dgvinventory.Size = new System.Drawing.Size(341, 234);
            this.dgvinventory.TabIndex = 0;
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "InventoryID";
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "InventoryID";
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.bookHavenDataSet;
            // 
            // bookHavenDataSet
            // 
            this.bookHavenDataSet.DataSetName = "BookHavenDataSet";
            this.bookHavenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryid
            // 
            this.inventoryid.AutoSize = true;
            this.inventoryid.ForeColor = System.Drawing.SystemColors.Control;
            this.inventoryid.Location = new System.Drawing.Point(40, 138);
            this.inventoryid.Name = "inventoryid";
            this.inventoryid.Size = new System.Drawing.Size(65, 13);
            this.inventoryid.TabIndex = 2;
            this.inventoryid.Text = "Inventory ID";
            // 
            // txtinventoryid
            // 
            this.txtinventoryid.Location = new System.Drawing.Point(171, 135);
            this.txtinventoryid.Name = "txtinventoryid";
            this.txtinventoryid.Size = new System.Drawing.Size(100, 20);
            this.txtinventoryid.TabIndex = 0;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.ForeColor = System.Drawing.SystemColors.Control;
            this.bookid.Location = new System.Drawing.Point(40, 189);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(46, 13);
            this.bookid.TabIndex = 3;
            this.bookid.Text = "Book ID";
            // 
            // stockquantity
            // 
            this.stockquantity.AutoSize = true;
            this.stockquantity.ForeColor = System.Drawing.SystemColors.Control;
            this.stockquantity.Location = new System.Drawing.Point(39, 234);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(77, 13);
            this.stockquantity.TabIndex = 5;
            this.stockquantity.Text = "Stock Quantity";
            // 
            // nudstockquantity
            // 
            this.nudstockquantity.Location = new System.Drawing.Point(170, 227);
            this.nudstockquantity.Name = "nudstockquantity";
            this.nudstockquantity.Size = new System.Drawing.Size(101, 20);
            this.nudstockquantity.TabIndex = 6;
            // 
            // btnrecord
            // 
            this.btnrecord.Location = new System.Drawing.Point(39, 395);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(75, 23);
            this.btnrecord.TabIndex = 9;
            this.btnrecord.Text = "Record";
            this.btnrecord.UseVisualStyleBackColor = true;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(171, 395);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(967, 448);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 28);
            this.btnback.TabIndex = 88;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button3_Click);
            // 
            // inventor
            // 
            this.inventor.AutoSize = true;
            this.inventor.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventor.ForeColor = System.Drawing.SystemColors.Control;
            this.inventor.Location = new System.Drawing.Point(434, 35);
            this.inventor.Name = "inventor";
            this.inventor.Size = new System.Drawing.Size(134, 36);
            this.inventor.TabIndex = 89;
            this.inventor.Text = "Inventory";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(171, 182);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(100, 20);
            this.txtbookid.TabIndex = 90;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dgvbook
            // 
            this.dgvbook.AllowUserToOrderColumns = true;
            this.dgvbook.AutoGenerateColumns = false;
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn1,
            this.bookTitleDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn1,
            this.publishedYearDataGridViewTextBoxColumn});
            this.dgvbook.DataSource = this.bookBindingSource;
            this.dgvbook.Location = new System.Drawing.Point(311, 127);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.Size = new System.Drawing.Size(341, 234);
            this.dgvbook.TabIndex = 91;
            this.dgvbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbook_CellContentClick);
            // 
            // bookIDDataGridViewTextBoxColumn1
            // 
            this.bookIDDataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.Name = "bookIDDataGridViewTextBoxColumn1";
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
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
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockQuantityDataGridViewTextBoxColumn1
            // 
            this.stockQuantityDataGridViewTextBoxColumn1.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn1.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn1.Name = "stockQuantityDataGridViewTextBoxColumn1";
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bookHavenDataSet1;
            // 
            // bookHavenDataSet1
            // 
            this.bookHavenDataSet1.DataSetName = "BookHavenDataSet1";
            this.bookHavenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookHavenDataSetBindingSource
            // 
            this.bookHavenDataSetBindingSource.DataSource = this.bookHavenDataSet;
            this.bookHavenDataSetBindingSource.Position = 0;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.inventor);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.nudstockquantity);
            this.Controls.Add(this.stockquantity);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.txtinventoryid);
            this.Controls.Add(this.inventoryid);
            this.Controls.Add(this.dgvinventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvinventory;
        private System.Windows.Forms.Label inventoryid;
        private System.Windows.Forms.TextBox txtinventoryid;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Label stockquantity;
        private System.Windows.Forms.NumericUpDown nudstockquantity;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label inventor;
        private System.Windows.Forms.TextBox txtbookid;
        private BookHavenDataSet bookHavenDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private BookHavenDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.BindingSource bookHavenDataSetBindingSource;
        private BookHavenDataSet1 bookHavenDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookHavenDataSet1TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
    }
}