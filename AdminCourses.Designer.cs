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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lecturer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesavailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblModule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLecturerEmail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLecturerNumber = new System.Windows.Forms.TextBox();
            this.moduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesavailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new IS_Team1_Project.databaseDataSet2();
            this.courses_availTableAdapter = new IS_Team1_Project.databaseDataSet1TableAdapters.courses_availTableAdapter();
            this.courses_availTableAdapter1 = new IS_Team1_Project.databaseDataSet2TableAdapters.courses_availTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesavailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesavailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(455, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleDataGridViewTextBoxColumn,
            this.lecturer_email,
            this.lecturer_number});
            this.dataGridView1.DataSource = this.coursesavailBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(222, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 357);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lecturer_email
            // 
            this.lecturer_email.DataPropertyName = "lecturer_email";
            this.lecturer_email.HeaderText = "lecturer_email";
            this.lecturer_email.MinimumWidth = 6;
            this.lecturer_email.Name = "lecturer_email";
            this.lecturer_email.ReadOnly = true;
            this.lecturer_email.Width = 97;
            // 
            // lecturer_number
            // 
            this.lecturer_number.DataPropertyName = "lecturer_number";
            this.lecturer_number.HeaderText = "lecturer_number";
            this.lecturer_number.MinimumWidth = 6;
            this.lecturer_number.Name = "lecturer_number";
            this.lecturer_number.ReadOnly = true;
            this.lecturer_number.Width = 108;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(674, 192);
            this.lblModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(65, 18);
            this.lblModule.TabIndex = 10;
            this.lblModule.Text = "Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(674, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lecturer Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(674, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lecturer Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(271, 480);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(136, 480);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(405, 480);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(539, 480);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 31);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(677, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 1);
            this.panel1.TabIndex = 18;
            // 
            // txtModule
            // 
            this.txtModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModule.ForeColor = System.Drawing.Color.White;
            this.txtModule.Location = new System.Drawing.Point(677, 213);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(212, 13);
            this.txtModule.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(677, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 1);
            this.panel2.TabIndex = 20;
            // 
            // txtLecturerEmail
            // 
            this.txtLecturerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtLecturerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLecturerEmail.ForeColor = System.Drawing.Color.White;
            this.txtLecturerEmail.Location = new System.Drawing.Point(677, 272);
            this.txtLecturerEmail.Name = "txtLecturerEmail";
            this.txtLecturerEmail.Size = new System.Drawing.Size(212, 13);
            this.txtLecturerEmail.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(677, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 1);
            this.panel3.TabIndex = 22;
            // 
            // txtLecturerNumber
            // 
            this.txtLecturerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtLecturerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLecturerNumber.ForeColor = System.Drawing.Color.White;
            this.txtLecturerNumber.Location = new System.Drawing.Point(677, 337);
            this.txtLecturerNumber.Name = "txtLecturerNumber";
            this.txtLecturerNumber.Size = new System.Drawing.Size(212, 13);
            this.txtLecturerNumber.TabIndex = 21;
            // 
            // moduleDataGridViewTextBoxColumn
            // 
            this.moduleDataGridViewTextBoxColumn.DataPropertyName = "module";
            this.moduleDataGridViewTextBoxColumn.HeaderText = "module";
            this.moduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moduleDataGridViewTextBoxColumn.Name = "moduleDataGridViewTextBoxColumn";
            this.moduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.moduleDataGridViewTextBoxColumn.Width = 66;
            // 
            // coursesavailBindingSource2
            // 
            this.coursesavailBindingSource2.DataMember = "courses_avail";
            this.coursesavailBindingSource2.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "databaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courses_availTableAdapter
            // 
            this.courses_availTableAdapter.ClearBeforeFill = true;
            // 
            // courses_availTableAdapter1
            // 
            this.courses_availTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtLecturerNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtLecturerEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCourses";
            this.Load += new System.EventHandler(this.AdminCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesavailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesavailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseDataSet1TableAdapters.courses_availTableAdapter courses_availTableAdapter;
        private System.Windows.Forms.BindingSource coursesavailBindingSource1;
        private databaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource coursesavailBindingSource2;
        private databaseDataSet2TableAdapters.courses_availTableAdapter courses_availTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer_number;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLecturerEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLecturerNumber;
    }
}