
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
            this.txtNewNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnnewDelete = new System.Windows.Forms.Button();
            this.btnnewAdd = new System.Windows.Forms.Button();
            this.btnnewUpdate = new System.Windows.Forms.Button();
            this.btnnewClear = new System.Windows.Forms.Button();
            this.databaseDataSet4 = new IS_Team1_Project.databaseDataSet4();
            this.academicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicTableAdapter = new IS_Team1_Project.databaseDataSet4TableAdapters.academicTableAdapter();
            this.tableAdapterManager = new IS_Team1_Project.databaseDataSet4TableAdapters.TableAdapterManager();
            this.academicDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1573, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewNum
            // 
            this.txtNewNum.Location = new System.Drawing.Point(1576, 458);
            this.txtNewNum.Name = "txtNewNum";
            this.txtNewNum.Size = new System.Drawing.Size(370, 35);
            this.txtNewNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1569, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Academic Email";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(1576, 541);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(370, 35);
            this.txtNewEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1569, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Name";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(1576, 624);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(370, 35);
            this.txtNewName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1573, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Academic Surname";
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.Location = new System.Drawing.Point(1576, 707);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(370, 35);
            this.txtNewSurname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1573, 745);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Academic Course";
            // 
            // txtNewCourse
            // 
            this.txtNewCourse.Location = new System.Drawing.Point(1576, 790);
            this.txtNewCourse.Name = "txtNewCourse";
            this.txtNewCourse.Size = new System.Drawing.Size(370, 35);
            this.txtNewCourse.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(1569, 828);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "Academic Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(1576, 873);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(370, 35);
            this.txtNewPass.TabIndex = 11;
            // 
            // btnnewDelete
            // 
            this.btnnewDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewDelete.Location = new System.Drawing.Point(2084, 458);
            this.btnnewDelete.Name = "btnnewDelete";
            this.btnnewDelete.Size = new System.Drawing.Size(233, 69);
            this.btnnewDelete.TabIndex = 12;
            this.btnnewDelete.Text = "Delete";
            this.btnnewDelete.UseVisualStyleBackColor = false;
            this.btnnewDelete.Click += new System.EventHandler(this.btnnewDelete_Click_1);
            // 
            // btnnewAdd
            // 
            this.btnnewAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewAdd.Location = new System.Drawing.Point(2084, 590);
            this.btnnewAdd.Name = "btnnewAdd";
            this.btnnewAdd.Size = new System.Drawing.Size(233, 69);
            this.btnnewAdd.TabIndex = 13;
            this.btnnewAdd.Text = "Add";
            this.btnnewAdd.UseVisualStyleBackColor = false;
            this.btnnewAdd.Click += new System.EventHandler(this.btnnewAdd_Click_1);
            // 
            // btnnewUpdate
            // 
            this.btnnewUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewUpdate.Location = new System.Drawing.Point(2084, 707);
            this.btnnewUpdate.Name = "btnnewUpdate";
            this.btnnewUpdate.Size = new System.Drawing.Size(233, 69);
            this.btnnewUpdate.TabIndex = 14;
            this.btnnewUpdate.Text = "Update";
            this.btnnewUpdate.UseVisualStyleBackColor = false;
            this.btnnewUpdate.Click += new System.EventHandler(this.btnnewUpdate_Click_1);
            // 
            // btnnewClear
            // 
            this.btnnewClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewClear.Location = new System.Drawing.Point(2084, 815);
            this.btnnewClear.Name = "btnnewClear";
            this.btnnewClear.Size = new System.Drawing.Size(233, 69);
            this.btnnewClear.TabIndex = 15;
            this.btnnewClear.Text = "Clear";
            this.btnnewClear.UseVisualStyleBackColor = false;
            this.btnnewClear.Click += new System.EventHandler(this.btnnewClear_Click_1);
            // 
            // databaseDataSet4
            // 
            this.databaseDataSet4.DataSetName = "databaseDataSet4";
            this.databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicBindingSource
            // 
            this.academicBindingSource.DataMember = "academic";
            this.academicBindingSource.DataSource = this.databaseDataSet4;
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
            // academicDataGridView
            // 
            this.academicDataGridView.AutoGenerateColumns = false;
            this.academicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.academicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.academicDataGridView.DataSource = this.academicBindingSource;
            this.academicDataGridView.Location = new System.Drawing.Point(25, 320);
            this.academicDataGridView.Name = "academicDataGridView";
            this.academicDataGridView.RowHeadersWidth = 92;
            this.academicDataGridView.RowTemplate.Height = 37;
            this.academicDataGridView.Size = new System.Drawing.Size(1521, 702);
            this.academicDataGridView.TabIndex = 17;
            this.academicDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGridView_CellClick);
            this.academicDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.academicDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "academic_num";
            this.dataGridViewTextBoxColumn1.HeaderText = "academic_num";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 225;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "academic_email";
            this.dataGridViewTextBoxColumn2.HeaderText = "academic_email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "academic_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "academic_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "academic_surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "academic_surname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "academic_course";
            this.dataGridViewTextBoxColumn5.HeaderText = "academic_course";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 225;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "academic_password";
            this.dataGridViewTextBoxColumn6.HeaderText = "academic_password";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 225;
            // 
            // PrathamFlopIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(2520, 1508);
            this.Controls.Add(this.academicDataGridView);
            this.Controls.Add(this.btnnewClear);
            this.Controls.Add(this.btnnewUpdate);
            this.Controls.Add(this.btnnewAdd);
            this.Controls.Add(this.btnnewDelete);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNewCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrathamFlopIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrathamFlopIS";
            this.Load += new System.EventHandler(this.PrathamFlopIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewPass;
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
    }
}