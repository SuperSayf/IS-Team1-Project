namespace IS_Team1_Project
{
    partial class AdminAcademic
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewNum = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewCourse = new System.Windows.Forms.TextBox();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.databaseDataSet41 = new IS_Team1_Project.databaseDataSet4();
            this.academicBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.academicTableAdapter2 = new IS_Team1_Project.databaseDataSet4TableAdapters.academicTableAdapter();
            this.tableAdapterManager2 = new IS_Team1_Project.databaseDataSet4TableAdapters.TableAdapterManager();
            this.btnnewUpdate = new System.Windows.Forms.Button();
            this.academicDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnewAdd = new System.Windows.Forms.Button();
            this.btnnewClear = new System.Windows.Forms.Button();
            this.btnnewDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1083, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 62);
            this.label7.TabIndex = 0;
            this.label7.Text = "Academics";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(60, 117);
            this.lblModule.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(343, 42);
            this.lblModule.TabIndex = 11;
            this.lblModule.Text = "Academic Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "Academic Email";
            // 
            // txtNewNum
            // 
            this.txtNewNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNum.Location = new System.Drawing.Point(67, 162);
            this.txtNewNum.Name = "txtNewNum";
            this.txtNewNum.Size = new System.Drawing.Size(370, 49);
            this.txtNewNum.TabIndex = 13;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmail.Location = new System.Drawing.Point(67, 282);
            this.txtNewEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(370, 49);
            this.txtNewEmail.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 42);
            this.label9.TabIndex = 15;
            this.label9.Text = "Academic Name";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(67, 781);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(370, 49);
            this.txtNewPass.TabIndex = 16;
            // 
            // txtNewCourse
            // 
            this.txtNewCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCourse.Location = new System.Drawing.Point(67, 648);
            this.txtNewCourse.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewCourse.Name = "txtNewCourse";
            this.txtNewCourse.Size = new System.Drawing.Size(370, 49);
            this.txtNewCourse.TabIndex = 17;
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSurname.Location = new System.Drawing.Point(67, 526);
            this.txtNewSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(370, 49);
            this.txtNewSurname.TabIndex = 18;
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(67, 404);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(370, 49);
            this.txtNewName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(60, 734);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "Academic Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 601);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 42);
            this.label12.TabIndex = 22;
            this.label12.Text = "Academic Course";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(60, 479);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(360, 42);
            this.label13.TabIndex = 23;
            this.label13.Text = "Academic Surname";
            // 
            // databaseDataSet41
            // 
            this.databaseDataSet41.DataSetName = "databaseDataSet4";
            this.databaseDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicBindingSource4
            // 
            this.academicBindingSource4.DataMember = "academic";
            this.academicBindingSource4.DataSource = this.databaseDataSet41;
            // 
            // academicTableAdapter2
            // 
            this.academicTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.academicTableAdapter = this.academicTableAdapter2;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = IS_Team1_Project.databaseDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnnewUpdate
            // 
            this.btnnewUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewUpdate.Location = new System.Drawing.Point(1232, 208);
            this.btnnewUpdate.Name = "btnnewUpdate";
            this.btnnewUpdate.Size = new System.Drawing.Size(233, 69);
            this.btnnewUpdate.TabIndex = 25;
            this.btnnewUpdate.Text = "Update";
            this.btnnewUpdate.UseVisualStyleBackColor = false;
            this.btnnewUpdate.Click += new System.EventHandler(this.btnnewUpdate_Click);
            // 
            // academicDataGridView1
            // 
            this.academicDataGridView1.AutoGenerateColumns = false;
            this.academicDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.academicDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.academicDataGridView1.DataSource = this.academicBindingSource4;
            this.academicDataGridView1.Location = new System.Drawing.Point(67, 893);
            this.academicDataGridView1.Name = "academicDataGridView1";
            this.academicDataGridView1.RowHeadersWidth = 92;
            this.academicDataGridView1.RowTemplate.Height = 37;
            this.academicDataGridView1.Size = new System.Drawing.Size(1448, 327);
            this.academicDataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "academic_num";
            this.dataGridViewTextBoxColumn7.HeaderText = "academic_num";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 225;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "academic_email";
            this.dataGridViewTextBoxColumn8.HeaderText = "academic_email";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 225;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "academic_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "academic_name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 225;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "academic_surname";
            this.dataGridViewTextBoxColumn10.HeaderText = "academic_surname";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 225;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "academic_course";
            this.dataGridViewTextBoxColumn11.HeaderText = "academic_course";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 225;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "academic_password";
            this.dataGridViewTextBoxColumn12.HeaderText = "academic_password";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 11;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 225;
            // 
            // btnnewAdd
            // 
            this.btnnewAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewAdd.Location = new System.Drawing.Point(1232, 330);
            this.btnnewAdd.Name = "btnnewAdd";
            this.btnnewAdd.Size = new System.Drawing.Size(233, 69);
            this.btnnewAdd.TabIndex = 26;
            this.btnnewAdd.Text = "Add";
            this.btnnewAdd.UseVisualStyleBackColor = false;
            this.btnnewAdd.Click += new System.EventHandler(this.btnnewAdd_Click);
            // 
            // btnnewClear
            // 
            this.btnnewClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewClear.Location = new System.Drawing.Point(1232, 574);
            this.btnnewClear.Name = "btnnewClear";
            this.btnnewClear.Size = new System.Drawing.Size(233, 69);
            this.btnnewClear.TabIndex = 27;
            this.btnnewClear.Text = "Clear";
            this.btnnewClear.UseVisualStyleBackColor = false;
            this.btnnewClear.Click += new System.EventHandler(this.btnnewClear_Click);
            // 
            // btnnewDelete
            // 
            this.btnnewDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnewDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewDelete.Location = new System.Drawing.Point(1232, 452);
            this.btnnewDelete.Name = "btnnewDelete";
            this.btnnewDelete.Size = new System.Drawing.Size(233, 69);
            this.btnnewDelete.TabIndex = 28;
            this.btnnewDelete.Text = "Delete";
            this.btnnewDelete.UseVisualStyleBackColor = false;
            this.btnnewDelete.Click += new System.EventHandler(this.btnnewDelete_Click);
            // 
            // AdminAcademic
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(2492, 1429);
            this.Controls.Add(this.btnnewDelete);
            this.Controls.Add(this.btnnewClear);
            this.Controls.Add(this.btnnewAdd);
            this.Controls.Add(this.academicDataGridView1);
            this.Controls.Add(this.btnnewUpdate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewSurname);
            this.Controls.Add(this.txtNewCourse);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtNewNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminAcademic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acadm";
            this.Load += new System.EventHandler(this.AdminAcademic_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private databaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource academicBindingSource;
        private databaseDataSet3TableAdapters.academicTableAdapter academicTableAdapter;
        private databaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator academicBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton academicBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox academic_numTextBox;
        private System.Windows.Forms.TextBox academic_emailTextBox;
        private System.Windows.Forms.TextBox academic_nameTextBox;
        private System.Windows.Forms.TextBox academic_surnameTextBox;
        private System.Windows.Forms.TextBox academic_courseTextBox;
        private System.Windows.Forms.TextBox academic_passwordTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource academicBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academiccourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource academicBindingSource2;
        private System.Windows.Forms.BindingSource databaseDataSet3BindingSource;
        private System.Windows.Forms.BindingSource databaseDataSet3BindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtacanum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtacaemail;
        private System.Windows.Forms.TextBox txtacaname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtacasur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtacacourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtacapass;
        private databaseDataSet4 databaseDataSet4;
        private System.Windows.Forms.BindingSource academicBindingSource3;
        private databaseDataSet4TableAdapters.academicTableAdapter academicTableAdapter1;
        private databaseDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator academicBindingSource3BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton academicBindingSource3BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView academicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewNum;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewCourse;
        private System.Windows.Forms.TextBox txtNewSurname;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private databaseDataSet4 databaseDataSet41;
        private System.Windows.Forms.BindingSource academicBindingSource4;
        private databaseDataSet4TableAdapters.academicTableAdapter academicTableAdapter2;
        private databaseDataSet4TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button btnnewUpdate;
        private System.Windows.Forms.DataGridView academicDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnnewAdd;
        private System.Windows.Forms.Button btnnewClear;
        private System.Windows.Forms.Button btnnewDelete;
    }
}