namespace LibManagementSystem_Updated.Forms
{
    partial class BookIssueForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIssue = new System.Windows.Forms.Button();
            this.labelStdId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStdName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-19, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1573, 735);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(1208, 50);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(136, 69);
            this.btnIssue.TabIndex = 1;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // labelStdId
            // 
            this.labelStdId.AutoSize = true;
            this.labelStdId.Location = new System.Drawing.Point(526, 69);
            this.labelStdId.Name = "labelStdId";
            this.labelStdId.Size = new System.Drawing.Size(162, 32);
            this.labelStdId.TabIndex = 3;
            this.labelStdId.Text = "Student ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 4;
            // 
            // labelStdName
            // 
            this.labelStdName.AutoSize = true;
            this.labelStdName.Location = new System.Drawing.Point(70, 69);
            this.labelStdName.Name = "labelStdName";
            this.labelStdName.Size = new System.Drawing.Size(210, 32);
            this.labelStdName.TabIndex = 5;
            this.labelStdName.Text = "Student Name: ";
            // 
            // BookIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 930);
            this.Controls.Add(this.labelStdName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStdId);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookIssueForm";
            this.Text = "BookIssueForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label labelStdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStdName;
    }
}