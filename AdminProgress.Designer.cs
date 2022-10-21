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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet2 = new IS_Team1_Project.databaseDataSet2();
            this.databaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new IS_Team1_Project.databaseDataSet3();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new IS_Team1_Project.databaseDataSet3TableAdapters.quizTableAdapter();
            this.quizIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizdifficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizpassDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quizscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(668, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progress";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quizIDDataGridViewTextBoxColumn,
            this.studentnumDataGridViewTextBoxColumn,
            this.quizdifficultyDataGridViewTextBoxColumn,
            this.quizpassDataGridViewCheckBoxColumn,
            this.quizscoreDataGridViewTextBoxColumn,
            this.quizcourseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quizBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(401, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 254);
            this.dataGridView1.TabIndex = 5;
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
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "databaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "quiz";
            this.quizBindingSource.DataSource = this.databaseDataSet3;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // quizIDDataGridViewTextBoxColumn
            // 
            this.quizIDDataGridViewTextBoxColumn.DataPropertyName = "quiz_ID";
            this.quizIDDataGridViewTextBoxColumn.HeaderText = "quiz_ID";
            this.quizIDDataGridViewTextBoxColumn.Name = "quizIDDataGridViewTextBoxColumn";
            // 
            // studentnumDataGridViewTextBoxColumn
            // 
            this.studentnumDataGridViewTextBoxColumn.DataPropertyName = "student_num";
            this.studentnumDataGridViewTextBoxColumn.HeaderText = "student_num";
            this.studentnumDataGridViewTextBoxColumn.Name = "studentnumDataGridViewTextBoxColumn";
            // 
            // quizdifficultyDataGridViewTextBoxColumn
            // 
            this.quizdifficultyDataGridViewTextBoxColumn.DataPropertyName = "quiz_difficulty";
            this.quizdifficultyDataGridViewTextBoxColumn.HeaderText = "quiz_difficulty";
            this.quizdifficultyDataGridViewTextBoxColumn.Name = "quizdifficultyDataGridViewTextBoxColumn";
            // 
            // quizpassDataGridViewCheckBoxColumn
            // 
            this.quizpassDataGridViewCheckBoxColumn.DataPropertyName = "quiz_pass";
            this.quizpassDataGridViewCheckBoxColumn.HeaderText = "quiz_pass";
            this.quizpassDataGridViewCheckBoxColumn.Name = "quizpassDataGridViewCheckBoxColumn";
            // 
            // quizscoreDataGridViewTextBoxColumn
            // 
            this.quizscoreDataGridViewTextBoxColumn.DataPropertyName = "quiz_score";
            this.quizscoreDataGridViewTextBoxColumn.HeaderText = "quiz_score";
            this.quizscoreDataGridViewTextBoxColumn.Name = "quizscoreDataGridViewTextBoxColumn";
            // 
            // quizcourseDataGridViewTextBoxColumn
            // 
            this.quizcourseDataGridViewTextBoxColumn.DataPropertyName = "quiz_course";
            this.quizcourseDataGridViewTextBoxColumn.HeaderText = "quiz_course";
            this.quizcourseDataGridViewTextBoxColumn.Name = "quizcourseDataGridViewTextBoxColumn";
            // 
            // AdminProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1440, 832);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProgress";
            this.Load += new System.EventHandler(this.AdminProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSet2BindingSource;
        private databaseDataSet2 databaseDataSet2;
        private databaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private databaseDataSet3TableAdapters.quizTableAdapter quizTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizdifficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn quizpassDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizcourseDataGridViewTextBoxColumn;
    }
}