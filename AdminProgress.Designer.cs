namespace IS_Team1_Project
{
    partial class AdminProgress
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
            this.myDataGrid = new System.Windows.Forms.DataGridView();
            this.resultsTxt = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.studentnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new IS_Team1_Project.databaseDataSet3();
            this.databaseDataSet2 = new IS_Team1_Project.databaseDataSet2();
            this.databaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new IS_Team1_Project.databaseDataSet3TableAdapters.quizTableAdapter();
            this.databaseDataSet = new IS_Team1_Project.databaseDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new IS_Team1_Project.databaseDataSetTableAdapters.studentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progress";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myDataGrid
            // 
            this.myDataGrid.AutoGenerateColumns = false;
            this.myDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnumDataGridViewTextBoxColumn});
            this.myDataGrid.DataSource = this.studentsBindingSource;
            this.myDataGrid.Location = new System.Drawing.Point(188, 112);
            this.myDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.myDataGrid.Name = "myDataGrid";
            this.myDataGrid.RowTemplate.Height = 24;
            this.myDataGrid.Size = new System.Drawing.Size(145, 376);
            this.myDataGrid.TabIndex = 5;
            this.myDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGrid_CellClick);
            // 
            // resultsTxt
            // 
            this.resultsTxt.AutoSize = true;
            this.resultsTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTxt.ForeColor = System.Drawing.Color.White;
            this.resultsTxt.Location = new System.Drawing.Point(376, 168);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(384, 22);
            this.resultsTxt.TabIndex = 6;
            this.resultsTxt.Text = "Click on a student number to view results";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(580, 536);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(100, 31);
            this.btnPrintReport.TabIndex = 15;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Visible = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // studentnumDataGridViewTextBoxColumn
            // 
            this.studentnumDataGridViewTextBoxColumn.DataPropertyName = "student_num";
            this.studentnumDataGridViewTextBoxColumn.HeaderText = "student_num";
            this.studentnumDataGridViewTextBoxColumn.Name = "studentnumDataGridViewTextBoxColumn";
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "quiz";
            this.quizBindingSource.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "databaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "databaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet2BindingSource
            // 
            this.databaseDataSet2BindingSource.DataSource = this.databaseDataSet2;
            this.databaseDataSet2BindingSource.Position = 0;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.myDataGrid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProgress";
            this.Load += new System.EventHandler(this.AdminProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView myDataGrid;
        private System.Windows.Forms.BindingSource databaseDataSet2BindingSource;
        private databaseDataSet2 databaseDataSet2;
        private databaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private databaseDataSet3TableAdapters.quizTableAdapter quizTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label resultsTxt;
        private System.Windows.Forms.Button btnPrintReport;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private databaseDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
    }
}