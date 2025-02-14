namespace LibManagementSystem_Updated
{
    partial class BooksForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(391, 116);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(248, 38);
            this.textBoxBookName.TabIndex = 0;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(391, 221);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(248, 38);
            this.textBoxAuthorName.TabIndex = 1;
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Location = new System.Drawing.Point(803, 159);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(164, 68);
            this.buttonSaveBook.TabIndex = 3;
            this.buttonSaveBook.Text = "Save";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(1055, 159);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(164, 68);
            this.buttonUpdateBook.TabIndex = 4;
            this.buttonUpdateBook.Text = "Update";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(1298, 159);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(164, 68);
            this.buttonDeleteBook.TabIndex = 5;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(-3, 605);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 102;
            this.dataGridViewBook.RowTemplate.Height = 40;
            this.dataGridViewBook.Size = new System.Drawing.Size(1936, 575);
            this.dataGridViewBook.TabIndex = 7;
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(149, 322);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(79, 32);
            this.ISBN.TabIndex = 9;
            this.ISBN.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(391, 322);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(248, 38);
            this.textBoxISBN.TabIndex = 2;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1926, 1169);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.buttonSaveBook);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BooksForm";
            this.Text = "Books Page";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox textBoxISBN;
    }
}