namespace LibManagementSystem_Updated
{
    partial class StudentsForm
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
            this.labelStudName = new System.Windows.Forms.Label();
            this.labelStudID = new System.Windows.Forms.Label();
            this.labelStudContact = new System.Windows.Forms.Label();
            this.textBoxStudID = new System.Windows.Forms.TextBox();
            this.textBoxStudContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewStudentForm = new System.Windows.Forms.DataGridView();
            this.textBoxStudName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Location = new System.Drawing.Point(219, 60);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(89, 32);
            this.labelStudName.TabIndex = 0;
            this.labelStudName.Text = "Name";
            // 
            // labelStudID
            // 
            this.labelStudID.AutoSize = true;
            this.labelStudID.Location = new System.Drawing.Point(219, 161);
            this.labelStudID.Name = "labelStudID";
            this.labelStudID.Size = new System.Drawing.Size(147, 32);
            this.labelStudID.TabIndex = 1;
            this.labelStudID.Text = "Student ID";
            // 
            // labelStudContact
            // 
            this.labelStudContact.AutoSize = true;
            this.labelStudContact.Location = new System.Drawing.Point(219, 266);
            this.labelStudContact.Name = "labelStudContact";
            this.labelStudContact.Size = new System.Drawing.Size(112, 32);
            this.labelStudContact.TabIndex = 2;
            this.labelStudContact.Text = "Contact";
            // 
            // textBoxStudID
            // 
            this.textBoxStudID.Location = new System.Drawing.Point(549, 161);
            this.textBoxStudID.Name = "textBoxStudID";
            this.textBoxStudID.Size = new System.Drawing.Size(193, 38);
            this.textBoxStudID.TabIndex = 1;
            // 
            // textBoxStudContact
            // 
            this.textBoxStudContact.Location = new System.Drawing.Point(549, 266);
            this.textBoxStudContact.Name = "textBoxStudContact";
            this.textBoxStudContact.Size = new System.Drawing.Size(193, 38);
            this.textBoxStudContact.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(849, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 86);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1096, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 86);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1366, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 86);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewStudentForm
            // 
            this.dataGridViewStudentForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentForm.Location = new System.Drawing.Point(3, 368);
            this.dataGridViewStudentForm.Name = "dataGridViewStudentForm";
            this.dataGridViewStudentForm.RowHeadersWidth = 102;
            this.dataGridViewStudentForm.RowTemplate.Height = 40;
            this.dataGridViewStudentForm.Size = new System.Drawing.Size(2036, 909);
            this.dataGridViewStudentForm.TabIndex = 9;
            this.dataGridViewStudentForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentForm_CellClick);
            // 
            // textBoxStudName
            // 
            this.textBoxStudName.Location = new System.Drawing.Point(549, 72);
            this.textBoxStudName.Name = "textBoxStudName";
            this.textBoxStudName.Size = new System.Drawing.Size(193, 38);
            this.textBoxStudName.TabIndex = 0;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1278);
            this.Controls.Add(this.textBoxStudName);
            this.Controls.Add(this.dataGridViewStudentForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxStudContact);
            this.Controls.Add(this.textBoxStudID);
            this.Controls.Add(this.labelStudContact);
            this.Controls.Add(this.labelStudID);
            this.Controls.Add(this.labelStudName);
            this.Name = "StudentsForm";
            this.Text = "Students Page";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudName;
        private System.Windows.Forms.Label labelStudID;
        private System.Windows.Forms.Label labelStudContact;
        private System.Windows.Forms.TextBox textBoxStudID;
        private System.Windows.Forms.TextBox textBoxStudContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewStudentForm;
        private System.Windows.Forms.TextBox textBoxStudName;
    }
}