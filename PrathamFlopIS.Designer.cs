
namespace IS_Team1_Project
{
    partial class PrathamFlopIS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnnewDelete = new System.Windows.Forms.Button();
            this.btnnewAdd = new System.Windows.Forms.Button();
            this.btnnewUpdate = new System.Windows.Forms.Button();
            this.btnnewClear = new System.Windows.Forms.Button();
            this.academicDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNewCourse = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet4 = new IS_Team1_Project.databaseDataSet4();
            this.academicTableAdapter = new IS_Team1_Project.databaseDataSet4TableAdapters.academicTableAdapter();
            this.tableAdapterManager = new IS_Team1_Project.databaseDataSet4TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(727, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(727, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Academic Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(727, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(727, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Academic Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(727, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Academic Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(727, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Academic Password";
            // 
            // btnnewDelete
            // 
            this.btnnewDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnewDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnnewDelete.ForeColor = System.Drawing.Color.White;
            this.btnnewDelete.Location = new System.Drawing.Point(184, 451);
            this.btnnewDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnnewDelete.Name = "btnnewDelete";
            this.btnnewDelete.Size = new System.Drawing.Size(100, 31);
            this.btnnewDelete.TabIndex = 12;
            this.btnnewDelete.Text = "Delete";
            this.btnnewDelete.UseVisualStyleBackColor = false;
            this.btnnewDelete.Click += new System.EventHandler(this.btnnewDelete_Click_1);
            // 
            // btnnewAdd
            // 
            this.btnnewAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnnewAdd.ForeColor = System.Drawing.Color.White;
            this.btnnewAdd.Location = new System.Drawing.Point(55, 451);
            this.btnnewAdd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnnewAdd.Name = "btnnewAdd";
            this.btnnewAdd.Size = new System.Drawing.Size(100, 31);
            this.btnnewAdd.TabIndex = 13;
            this.btnnewAdd.Text = "Add";
            this.btnnewAdd.UseVisualStyleBackColor = false;
            this.btnnewAdd.Click += new System.EventHandler(this.btnnewAdd_Click_1);
            // 
            // btnnewUpdate
            // 
            this.btnnewUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnewUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnnewUpdate.ForeColor = System.Drawing.Color.White;
            this.btnnewUpdate.Location = new System.Drawing.Point(308, 451);
            this.btnnewUpdate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnnewUpdate.Name = "btnnewUpdate";
            this.btnnewUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnnewUpdate.TabIndex = 14;
            this.btnnewUpdate.Text = "Update";
            this.btnnewUpdate.UseVisualStyleBackColor = false;
            this.btnnewUpdate.Click += new System.EventHandler(this.btnnewUpdate_Click_1);
            // 
            // btnnewClear
            // 
            this.btnnewClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnnewClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnnewClear.ForeColor = System.Drawing.Color.White;
            this.btnnewClear.Location = new System.Drawing.Point(437, 451);
            this.btnnewClear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnnewClear.Name = "btnnewClear";
            this.btnnewClear.Size = new System.Drawing.Size(100, 31);
            this.btnnewClear.TabIndex = 15;
            this.btnnewClear.Text = "Clear";
            this.btnnewClear.UseVisualStyleBackColor = false;
            this.btnnewClear.Click += new System.EventHandler(this.btnnewClear_Click_1);
            // 
            // academicDataGridView
            // 
            this.academicDataGridView.AutoGenerateColumns = false;
            this.academicDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.academicDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.academicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.academicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.academicDataGridView.DataSource = this.academicBindingSource;
            this.academicDataGridView.Location = new System.Drawing.Point(55, 112);
            this.academicDataGridView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.academicDataGridView.Name = "academicDataGridView";
            this.academicDataGridView.RowHeadersWidth = 92;
            this.academicDataGridView.RowTemplate.Height = 37;
            this.academicDataGridView.Size = new System.Drawing.Size(652, 315);
            this.academicDataGridView.TabIndex = 17;
            this.academicDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGridView_CellClick);
            this.academicDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(730, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 1);
            this.panel1.TabIndex = 19;
            // 
            // txtNewNum
            // 
            this.txtNewNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewNum.ForeColor = System.Drawing.Color.White;
            this.txtNewNum.Location = new System.Drawing.Point(730, 133);
            this.txtNewNum.Name = "txtNewNum";
            this.txtNewNum.Size = new System.Drawing.Size(152, 13);
            this.txtNewNum.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(730, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 1);
            this.panel2.TabIndex = 21;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewEmail.ForeColor = System.Drawing.Color.White;
            this.txtNewEmail.Location = new System.Drawing.Point(730, 195);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(152, 13);
            this.txtNewEmail.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(730, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 1);
            this.panel3.TabIndex = 23;
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewName.ForeColor = System.Drawing.Color.White;
            this.txtNewName.Location = new System.Drawing.Point(730, 254);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(152, 13);
            this.txtNewName.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(730, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 1);
            this.panel4.TabIndex = 25;
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewSurname.ForeColor = System.Drawing.Color.White;
            this.txtNewSurname.Location = new System.Drawing.Point(730, 313);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(152, 13);
            this.txtNewSurname.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(730, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 1);
            this.panel5.TabIndex = 27;
            // 
            // txtNewCourse
            // 
            this.txtNewCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewCourse.ForeColor = System.Drawing.Color.White;
            this.txtNewCourse.Location = new System.Drawing.Point(730, 368);
            this.txtNewCourse.Name = "txtNewCourse";
            this.txtNewCourse.Size = new System.Drawing.Size(152, 13);
            this.txtNewCourse.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(730, 438);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 1);
            this.panel6.TabIndex = 29;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.Location = new System.Drawing.Point(730, 421);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(152, 13);
            this.txtNewPass.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "academic_num";
            this.dataGridViewTextBoxColumn1.HeaderText = "academic_num";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "academic_email";
            this.dataGridViewTextBoxColumn2.HeaderText = "academic_email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "academic_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "academic_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "academic_surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "academic_surname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 124;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "academic_course";
            this.dataGridViewTextBoxColumn5.HeaderText = "academic_course";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 116;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "academic_password";
            this.dataGridViewTextBoxColumn6.HeaderText = "academic_password";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 129;
            // 
            // academicBindingSource
            // 
            this.academicBindingSource.DataMember = "academic";
            this.academicBindingSource.DataSource = this.databaseDataSet4;
            // 
            // databaseDataSet4
            // 
            this.databaseDataSet4.DataSetName = "databaseDataSet4";
            this.databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicTableAdapter
            // 
            this.academicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.academicTableAdapter = this.academicTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = IS_Team1_Project.databaseDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PrathamFlopIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtNewCourse);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtNewSurname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNewNum);
            this.Controls.Add(this.academicDataGridView);
            this.Controls.Add(this.btnnewClear);
            this.Controls.Add(this.btnnewUpdate);
            this.Controls.Add(this.btnnewAdd);
            this.Controls.Add(this.btnnewDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "PrathamFlopIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrathamFlopIS";
            this.Load += new System.EventHandler(this.PrathamFlopIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnewDelete;
        private System.Windows.Forms.Button btnnewAdd;
        private System.Windows.Forms.Button btnnewUpdate;
        private System.Windows.Forms.Button btnnewClear;
        private databaseDataSet4 databaseDataSet4;
        private System.Windows.Forms.BindingSource academicBindingSource;
        private databaseDataSet4TableAdapters.academicTableAdapter academicTableAdapter;
        private databaseDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView academicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNewSurname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNewCourse;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNewPass;
    }
}