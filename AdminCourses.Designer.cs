namespace IS_Team1_Project
{
    partial class AdminCourses
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
            this.label2 = new System.Windows.Forms.Label();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new IS_Team1_Project.databaseDataSet();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new IS_Team1_Project.databaseDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new IS_Team1_Project.databaseDataSetTableAdapters.coursesTableAdapter();
            this.studentsTableAdapter = new IS_Team1_Project.databaseDataSetTableAdapters.studentsTableAdapter();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new IS_Team1_Project.databaseDataSetTableAdapters.adminTableAdapter();
            this.adminnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(607, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courses";
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "courses";
            this.coursesBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
            this.studentsBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.databaseDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "students";
            this.studentsBindingSource2.DataSource = this.databaseDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminnumDataGridViewTextBoxColumn,
            this.adminemailDataGridViewTextBoxColumn,
            this.adminnameDataGridViewTextBoxColumn,
            this.adminsurnameDataGridViewTextBoxColumn,
            this.adminpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.databaseDataSet1;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // adminnumDataGridViewTextBoxColumn
            // 
            this.adminnumDataGridViewTextBoxColumn.DataPropertyName = "admin_num";
            this.adminnumDataGridViewTextBoxColumn.HeaderText = "admin_num";
            this.adminnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminnumDataGridViewTextBoxColumn.Name = "adminnumDataGridViewTextBoxColumn";
            this.adminnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminemailDataGridViewTextBoxColumn
            // 
            this.adminemailDataGridViewTextBoxColumn.DataPropertyName = "admin_email";
            this.adminemailDataGridViewTextBoxColumn.HeaderText = "admin_email";
            this.adminemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminemailDataGridViewTextBoxColumn.Name = "adminemailDataGridViewTextBoxColumn";
            this.adminemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminemailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminnameDataGridViewTextBoxColumn
            // 
            this.adminnameDataGridViewTextBoxColumn.DataPropertyName = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.HeaderText = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminnameDataGridViewTextBoxColumn.Name = "adminnameDataGridViewTextBoxColumn";
            this.adminnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminsurnameDataGridViewTextBoxColumn
            // 
            this.adminsurnameDataGridViewTextBoxColumn.DataPropertyName = "admin_surname";
            this.adminsurnameDataGridViewTextBoxColumn.HeaderText = "admin_surname";
            this.adminsurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminsurnameDataGridViewTextBoxColumn.Name = "adminsurnameDataGridViewTextBoxColumn";
            this.adminsurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminsurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminpasswordDataGridViewTextBoxColumn
            // 
            this.adminpasswordDataGridViewTextBoxColumn.DataPropertyName = "admin_password";
            this.adminpasswordDataGridViewTextBoxColumn.HeaderText = "admin_password";
            this.adminpasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminpasswordDataGridViewTextBoxColumn.Name = "adminpasswordDataGridViewTextBoxColumn";
            this.adminpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminpasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1440, 832);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCourses";
            this.Load += new System.EventHandler(this.AdminCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private databaseDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private databaseDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private databaseDataSet databaseDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private databaseDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminpasswordDataGridViewTextBoxColumn;
    }
}