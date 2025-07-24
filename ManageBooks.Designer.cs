namespace BookHaven
{
    partial class ManageBooks
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
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.gbauthorname = new System.Windows.Forms.GroupBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.cmbtitle = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.booktitle = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.Label();
            this.stockquantity = new System.Windows.Forms.Label();
            this.nudstockquantity = new System.Windows.Forms.NumericUpDown();
            this.publishedyear = new System.Windows.Forms.Label();
            this.txtpublishedyear = new System.Windows.Forms.TextBox();
            this.dgvbooks = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookHavenDataSet5 = new BookHaven.BookHavenDataSet5();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.managebook = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.bookTableAdapter = new BookHaven.BookHavenDataSet5TableAdapters.BookTableAdapter();
            this.gbauthorname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(172, 128);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(100, 20);
            this.txtbookid.TabIndex = 35;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.ForeColor = System.Drawing.SystemColors.Control;
            this.bookid.Location = new System.Drawing.Point(82, 131);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(46, 13);
            this.bookid.TabIndex = 34;
            this.bookid.Text = "Book ID";
            // 
            // gbauthorname
            // 
            this.gbauthorname.Controls.Add(this.txtlastname);
            this.gbauthorname.Controls.Add(this.lastname);
            this.gbauthorname.Controls.Add(this.txtfirstname);
            this.gbauthorname.Controls.Add(this.firstname);
            this.gbauthorname.Controls.Add(this.cmbtitle);
            this.gbauthorname.Controls.Add(this.title);
            this.gbauthorname.ForeColor = System.Drawing.SystemColors.Control;
            this.gbauthorname.Location = new System.Drawing.Point(75, 212);
            this.gbauthorname.Name = "gbauthorname";
            this.gbauthorname.Size = new System.Drawing.Size(281, 146);
            this.gbauthorname.TabIndex = 37;
            this.gbauthorname.TabStop = false;
            this.gbauthorname.Text = "Author Name";
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
            // txtbooktitle
            // 
            this.txtbooktitle.Location = new System.Drawing.Point(172, 167);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(100, 20);
            this.txtbooktitle.TabIndex = 39;
            // 
            // booktitle
            // 
            this.booktitle.AutoSize = true;
            this.booktitle.ForeColor = System.Drawing.SystemColors.Control;
            this.booktitle.Location = new System.Drawing.Point(82, 170);
            this.booktitle.Name = "booktitle";
            this.booktitle.Size = new System.Drawing.Size(55, 13);
            this.booktitle.TabIndex = 38;
            this.booktitle.Text = "Book Title";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(487, 164);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(100, 20);
            this.txtisbn.TabIndex = 43;
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.ForeColor = System.Drawing.SystemColors.Control;
            this.isbn.Location = new System.Drawing.Point(397, 167);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(32, 13);
            this.isbn.TabIndex = 42;
            this.isbn.Text = "ISBN";
            // 
            // txtgenre
            // 
            this.txtgenre.Location = new System.Drawing.Point(487, 125);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(100, 20);
            this.txtgenre.TabIndex = 41;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.Control;
            this.genre.Location = new System.Drawing.Point(397, 128);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(36, 13);
            this.genre.TabIndex = 40;
            this.genre.Text = "Genre";
            // 
            // stockquantity
            // 
            this.stockquantity.AutoSize = true;
            this.stockquantity.ForeColor = System.Drawing.SystemColors.Control;
            this.stockquantity.Location = new System.Drawing.Point(396, 256);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(77, 13);
            this.stockquantity.TabIndex = 44;
            this.stockquantity.Text = "Stock Quantity";
            // 
            // nudstockquantity
            // 
            this.nudstockquantity.Location = new System.Drawing.Point(487, 254);
            this.nudstockquantity.Name = "nudstockquantity";
            this.nudstockquantity.Size = new System.Drawing.Size(100, 20);
            this.nudstockquantity.TabIndex = 45;
            // 
            // publishedyear
            // 
            this.publishedyear.AutoSize = true;
            this.publishedyear.ForeColor = System.Drawing.SystemColors.Control;
            this.publishedyear.Location = new System.Drawing.Point(396, 305);
            this.publishedyear.Name = "publishedyear";
            this.publishedyear.Size = new System.Drawing.Size(78, 13);
            this.publishedyear.TabIndex = 46;
            this.publishedyear.Text = "Published Year";
            // 
            // txtpublishedyear
            // 
            this.txtpublishedyear.Location = new System.Drawing.Point(487, 298);
            this.txtpublishedyear.Name = "txtpublishedyear";
            this.txtpublishedyear.Size = new System.Drawing.Size(100, 20);
            this.txtpublishedyear.TabIndex = 47;
            // 
            // dgvbooks
            // 
            this.dgvbooks.AllowUserToOrderColumns = true;
            this.dgvbooks.AutoGenerateColumns = false;
            this.dgvbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn});
            this.dgvbooks.DataSource = this.bookBindingSource;
            this.dgvbooks.Location = new System.Drawing.Point(659, 116);
            this.dgvbooks.Name = "dgvbooks";
            this.dgvbooks.Size = new System.Drawing.Size(341, 283);
            this.dgvbooks.TabIndex = 85;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
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
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
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
            this.bookBindingSource.DataSource = this.bookHavenDataSet5;
            // 
            // bookHavenDataSet5
            // 
            this.bookHavenDataSet5.DataSetName = "BookHavenDataSet5";
            this.bookHavenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(423, 433);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 89;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(309, 433);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 88;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(197, 433);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 87;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(85, 433);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 86;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Location = new System.Drawing.Point(940, 430);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(60, 28);
            this.btnback.TabIndex = 90;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // managebook
            // 
            this.managebook.AutoSize = true;
            this.managebook.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managebook.ForeColor = System.Drawing.SystemColors.Control;
            this.managebook.Location = new System.Drawing.Point(431, 30);
            this.managebook.Name = "managebook";
            this.managebook.Size = new System.Drawing.Size(194, 36);
            this.managebook.TabIndex = 91;
            this.managebook.Text = "Manage Books";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(487, 209);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 93;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.ForeColor = System.Drawing.SystemColors.Control;
            this.price.Location = new System.Drawing.Point(397, 212);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 92;
            this.price.Text = "Price";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(538, 433);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 94;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.managebook);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvbooks);
            this.Controls.Add(this.txtpublishedyear);
            this.Controls.Add(this.publishedyear);
            this.Controls.Add(this.nudstockquantity);
            this.Controls.Add(this.stockquantity);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.txtgenre);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.booktitle);
            this.Controls.Add(this.gbauthorname);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.bookid);
            this.Name = "ManageBooks";
            this.Text = "ManageBooks";
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            this.gbauthorname.ResumeLayout(false);
            this.gbauthorname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookHavenDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.GroupBox gbauthorname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.ComboBox cmbtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.Label booktitle;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label stockquantity;
        private System.Windows.Forms.NumericUpDown nudstockquantity;
        private System.Windows.Forms.Label publishedyear;
        private System.Windows.Forms.TextBox txtpublishedyear;
        private System.Windows.Forms.DataGridView dgvbooks;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label managebook;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button btnsearch;
        private BookHavenDataSet5 bookHavenDataSet5;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookHavenDataSet5TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
    }
}