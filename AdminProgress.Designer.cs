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
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new IS_Team1_Project.databaseDataSet3();
            this.databaseDataSet2 = new IS_Team1_Project.databaseDataSet2();
            this.databaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new IS_Team1_Project.databaseDataSet3TableAdapters.quizTableAdapter();
            this.studentnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(480, 255);
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
            this.myDataGrid.DataSource = this.quizBindingSource;
            this.myDataGrid.Location = new System.Drawing.Point(305, 311);
            this.myDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.myDataGrid.Name = "myDataGrid";
            this.myDataGrid.RowTemplate.Height = 24;
            this.myDataGrid.Size = new System.Drawing.Size(145, 206);
            this.myDataGrid.TabIndex = 5;
            this.myDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGrid_CellClick);
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
            // studentnumDataGridViewTextBoxColumn
            // 
            this.studentnumDataGridViewTextBoxColumn.DataPropertyName = "student_num";
            this.studentnumDataGridViewTextBoxColumn.HeaderText = "student_num";
            this.studentnumDataGridViewTextBoxColumn.Name = "studentnumDataGridViewTextBoxColumn";
            // 
            // resultsTxt
            // 
            this.resultsTxt.AutoSize = true;
            this.resultsTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTxt.ForeColor = System.Drawing.Color.White;
            this.resultsTxt.Location = new System.Drawing.Point(481, 311);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(93, 22);
            this.resultsTxt.TabIndex = 6;
            this.resultsTxt.Text = "Progress";
            // 
            // AdminProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
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
    }
}