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
            System.Windows.Forms.Label academic_numLabel;
            System.Windows.Forms.Label academic_emailLabel;
            System.Windows.Forms.Label academic_nameLabel;
            System.Windows.Forms.Label academic_surnameLabel;
            System.Windows.Forms.Label academic_courseLabel;
            System.Windows.Forms.Label academic_passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAcademic));
            this.databaseDataSet3 = new IS_Team1_Project.databaseDataSet3();
            this.academicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicTableAdapter = new IS_Team1_Project.databaseDataSet3TableAdapters.academicTableAdapter();
            this.tableAdapterManager = new IS_Team1_Project.databaseDataSet3TableAdapters.TableAdapterManager();
            this.academicBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.academicBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.academic_numTextBox = new System.Windows.Forms.TextBox();
            this.academic_emailTextBox = new System.Windows.Forms.TextBox();
            this.academic_nameTextBox = new System.Windows.Forms.TextBox();
            this.academic_surnameTextBox = new System.Windows.Forms.TextBox();
            this.academic_courseTextBox = new System.Windows.Forms.TextBox();
            this.academic_passwordTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.academicnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academiccourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            academic_numLabel = new System.Windows.Forms.Label();
            academic_emailLabel = new System.Windows.Forms.Label();
            academic_nameLabel = new System.Windows.Forms.Label();
            academic_surnameLabel = new System.Windows.Forms.Label();
            academic_courseLabel = new System.Windows.Forms.Label();
            academic_passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingNavigator)).BeginInit();
            this.academicBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // academic_numLabel
            // 
            academic_numLabel.AutoSize = true;
            academic_numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_numLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_numLabel.Location = new System.Drawing.Point(117, 305);
            academic_numLabel.Name = "academic_numLabel";
            academic_numLabel.Size = new System.Drawing.Size(261, 40);
            academic_numLabel.TabIndex = 5;
            academic_numLabel.Text = "academic num:";
            // 
            // academic_emailLabel
            // 
            academic_emailLabel.AutoSize = true;
            academic_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_emailLabel.Location = new System.Drawing.Point(117, 352);
            academic_emailLabel.Name = "academic_emailLabel";
            academic_emailLabel.Size = new System.Drawing.Size(277, 40);
            academic_emailLabel.TabIndex = 7;
            academic_emailLabel.Text = "academic email:";
            // 
            // academic_nameLabel
            // 
            academic_nameLabel.AutoSize = true;
            academic_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_nameLabel.Location = new System.Drawing.Point(117, 405);
            academic_nameLabel.Name = "academic_nameLabel";
            academic_nameLabel.Size = new System.Drawing.Size(281, 40);
            academic_nameLabel.TabIndex = 9;
            academic_nameLabel.Text = "academic name:";
            // 
            // academic_surnameLabel
            // 
            academic_surnameLabel.AutoSize = true;
            academic_surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_surnameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_surnameLabel.Location = new System.Drawing.Point(117, 465);
            academic_surnameLabel.Name = "academic_surnameLabel";
            academic_surnameLabel.Size = new System.Drawing.Size(331, 40);
            academic_surnameLabel.TabIndex = 11;
            academic_surnameLabel.Text = "academic surname:";
            // 
            // academic_courseLabel
            // 
            academic_courseLabel.AutoSize = true;
            academic_courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_courseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_courseLabel.Location = new System.Drawing.Point(117, 520);
            academic_courseLabel.Name = "academic_courseLabel";
            academic_courseLabel.Size = new System.Drawing.Size(299, 40);
            academic_courseLabel.TabIndex = 13;
            academic_courseLabel.Text = "academic course:";
            // 
            // academic_passwordLabel
            // 
            academic_passwordLabel.AutoSize = true;
            academic_passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            academic_passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            academic_passwordLabel.Location = new System.Drawing.Point(117, 576);
            academic_passwordLabel.Name = "academic_passwordLabel";
            academic_passwordLabel.Size = new System.Drawing.Size(345, 40);
            academic_passwordLabel.TabIndex = 15;
            academic_passwordLabel.Text = "academic password:";
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "databaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicBindingSource
            // 
            this.academicBindingSource.DataMember = "academic";
            this.academicBindingSource.DataSource = this.databaseDataSet3;
            // 
            // academicTableAdapter
            // 
            this.academicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.academicTableAdapter = this.academicTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = IS_Team1_Project.databaseDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // academicBindingNavigator
            // 
            this.academicBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.academicBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.academicBindingNavigator.BindingSource = this.academicBindingSource;
            this.academicBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.academicBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.academicBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.academicBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.academicBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.academicBindingNavigatorSaveItem});
            this.academicBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.academicBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.academicBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.academicBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.academicBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.academicBindingNavigator.Name = "academicBindingNavigator";
            this.academicBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.academicBindingNavigator.Size = new System.Drawing.Size(538, 46);
            this.academicBindingNavigator.TabIndex = 5;
            this.academicBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(79, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 43);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // academicBindingNavigatorSaveItem
            // 
            this.academicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.academicBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("academicBindingNavigatorSaveItem.Image")));
            this.academicBindingNavigatorSaveItem.Name = "academicBindingNavigatorSaveItem";
            this.academicBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 40);
            this.academicBindingNavigatorSaveItem.Text = "Save Data";
            this.academicBindingNavigatorSaveItem.Click += new System.EventHandler(this.academicBindingNavigatorSaveItem_Click);
            // 
            // academic_numTextBox
            // 
            this.academic_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_num", true));
            this.academic_numTextBox.Location = new System.Drawing.Point(535, 312);
            this.academic_numTextBox.Name = "academic_numTextBox";
            this.academic_numTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_numTextBox.TabIndex = 6;
            this.academic_numTextBox.TextChanged += new System.EventHandler(this.academic_numTextBox_TextChanged);
            // 
            // academic_emailTextBox
            // 
            this.academic_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_email", true));
            this.academic_emailTextBox.Location = new System.Drawing.Point(535, 359);
            this.academic_emailTextBox.Name = "academic_emailTextBox";
            this.academic_emailTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_emailTextBox.TabIndex = 8;
            // 
            // academic_nameTextBox
            // 
            this.academic_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_name", true));
            this.academic_nameTextBox.Location = new System.Drawing.Point(535, 410);
            this.academic_nameTextBox.Name = "academic_nameTextBox";
            this.academic_nameTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_nameTextBox.TabIndex = 10;
            // 
            // academic_surnameTextBox
            // 
            this.academic_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_surname", true));
            this.academic_surnameTextBox.Location = new System.Drawing.Point(535, 465);
            this.academic_surnameTextBox.Name = "academic_surnameTextBox";
            this.academic_surnameTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_surnameTextBox.TabIndex = 12;
            // 
            // academic_courseTextBox
            // 
            this.academic_courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_course", true));
            this.academic_courseTextBox.Location = new System.Drawing.Point(535, 525);
            this.academic_courseTextBox.Name = "academic_courseTextBox";
            this.academic_courseTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_courseTextBox.TabIndex = 14;
            // 
            // academic_passwordTextBox
            // 
            this.academic_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicBindingSource, "academic_password", true));
            this.academic_passwordTextBox.Location = new System.Drawing.Point(535, 581);
            this.academic_passwordTextBox.Name = "academic_passwordTextBox";
            this.academic_passwordTextBox.Size = new System.Drawing.Size(400, 35);
            this.academic_passwordTextBox.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.academicnumDataGridViewTextBoxColumn,
            this.academicemailDataGridViewTextBoxColumn,
            this.academicnameDataGridViewTextBoxColumn,
            this.academicsurnameDataGridViewTextBoxColumn,
            this.academiccourseDataGridViewTextBoxColumn,
            this.academicpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.academicBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(107, 765);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(2179, 403);
            this.dataGridView1.TabIndex = 17;
            // 
            // academicnumDataGridViewTextBoxColumn
            // 
            this.academicnumDataGridViewTextBoxColumn.DataPropertyName = "academic_num";
            this.academicnumDataGridViewTextBoxColumn.HeaderText = "academic_num";
            this.academicnumDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academicnumDataGridViewTextBoxColumn.Name = "academicnumDataGridViewTextBoxColumn";
            this.academicnumDataGridViewTextBoxColumn.Width = 225;
            // 
            // academicemailDataGridViewTextBoxColumn
            // 
            this.academicemailDataGridViewTextBoxColumn.DataPropertyName = "academic_email";
            this.academicemailDataGridViewTextBoxColumn.HeaderText = "academic_email";
            this.academicemailDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academicemailDataGridViewTextBoxColumn.Name = "academicemailDataGridViewTextBoxColumn";
            this.academicemailDataGridViewTextBoxColumn.Width = 225;
            // 
            // academicnameDataGridViewTextBoxColumn
            // 
            this.academicnameDataGridViewTextBoxColumn.DataPropertyName = "academic_name";
            this.academicnameDataGridViewTextBoxColumn.HeaderText = "academic_name";
            this.academicnameDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academicnameDataGridViewTextBoxColumn.Name = "academicnameDataGridViewTextBoxColumn";
            this.academicnameDataGridViewTextBoxColumn.Width = 225;
            // 
            // academicsurnameDataGridViewTextBoxColumn
            // 
            this.academicsurnameDataGridViewTextBoxColumn.DataPropertyName = "academic_surname";
            this.academicsurnameDataGridViewTextBoxColumn.HeaderText = "academic_surname";
            this.academicsurnameDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academicsurnameDataGridViewTextBoxColumn.Name = "academicsurnameDataGridViewTextBoxColumn";
            this.academicsurnameDataGridViewTextBoxColumn.Width = 225;
            // 
            // academiccourseDataGridViewTextBoxColumn
            // 
            this.academiccourseDataGridViewTextBoxColumn.DataPropertyName = "academic_course";
            this.academiccourseDataGridViewTextBoxColumn.HeaderText = "academic_course";
            this.academiccourseDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academiccourseDataGridViewTextBoxColumn.Name = "academiccourseDataGridViewTextBoxColumn";
            this.academiccourseDataGridViewTextBoxColumn.Width = 225;
            // 
            // academicpasswordDataGridViewTextBoxColumn
            // 
            this.academicpasswordDataGridViewTextBoxColumn.DataPropertyName = "academic_password";
            this.academicpasswordDataGridViewTextBoxColumn.HeaderText = "academic_password";
            this.academicpasswordDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.academicpasswordDataGridViewTextBoxColumn.Name = "academicpasswordDataGridViewTextBoxColumn";
            this.academicpasswordDataGridViewTextBoxColumn.Width = 225;
            // 
            // academicBindingSource2
            // 
            this.academicBindingSource2.DataMember = "academic";
            this.academicBindingSource2.DataSource = this.databaseDataSet3BindingSource;
            // 
            // databaseDataSet3BindingSource
            // 
            this.databaseDataSet3BindingSource.DataSource = this.databaseDataSet3;
            this.databaseDataSet3BindingSource.Position = 0;
            // 
            // academicBindingSource1
            // 
            this.academicBindingSource1.DataMember = "academic";
            this.academicBindingSource1.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3BindingSource1
            // 
            this.databaseDataSet3BindingSource1.DataSource = this.databaseDataSet3;
            this.databaseDataSet3BindingSource1.Position = 0;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // AdminAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(2520, 1508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(academic_numLabel);
            this.Controls.Add(this.academic_numTextBox);
            this.Controls.Add(academic_emailLabel);
            this.Controls.Add(this.academic_emailTextBox);
            this.Controls.Add(academic_nameLabel);
            this.Controls.Add(this.academic_nameTextBox);
            this.Controls.Add(academic_surnameLabel);
            this.Controls.Add(this.academic_surnameTextBox);
            this.Controls.Add(academic_courseLabel);
            this.Controls.Add(this.academic_courseTextBox);
            this.Controls.Add(academic_passwordLabel);
            this.Controls.Add(this.academic_passwordTextBox);
            this.Controls.Add(this.academicBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AdminAcademic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAcademic";
            this.Load += new System.EventHandler(this.AdminAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingNavigator)).EndInit();
            this.academicBindingNavigator.ResumeLayout(false);
            this.academicBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource1)).EndInit();
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
    }
}