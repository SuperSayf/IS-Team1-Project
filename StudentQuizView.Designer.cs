namespace IS_Team1_Project
{
    partial class StudentQuizView
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radTrue = new System.Windows.Forms.RadioButton();
            this.radFalse = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblQuestNum = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCourseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(429, 28);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(202, 24);
            this.lblCourseName.TabIndex = 19;
            this.lblCourseName.Text = "Course Name Here";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDifficulty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(455, 82);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(135, 24);
            this.lblDifficulty.TabIndex = 20;
            this.lblDifficulty.Text = "Level: Insert";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(199, 231);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(123, 18);
            this.lblQuestion.TabIndex = 21;
            this.lblQuestion.Text = "Question Here";
            // 
            // radTrue
            // 
            this.radTrue.AutoSize = true;
            this.radTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTrue.ForeColor = System.Drawing.Color.White;
            this.radTrue.Location = new System.Drawing.Point(202, 434);
            this.radTrue.Name = "radTrue";
            this.radTrue.Size = new System.Drawing.Size(49, 16);
            this.radTrue.TabIndex = 22;
            this.radTrue.TabStop = true;
            this.radTrue.Text = "True";
            this.radTrue.UseVisualStyleBackColor = true;
            this.radTrue.Visible = false;
            // 
            // radFalse
            // 
            this.radFalse.AutoSize = true;
            this.radFalse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFalse.ForeColor = System.Drawing.Color.White;
            this.radFalse.Location = new System.Drawing.Point(771, 434);
            this.radFalse.Name = "radFalse";
            this.radFalse.Size = new System.Drawing.Size(53, 16);
            this.radFalse.TabIndex = 23;
            this.radFalse.TabStop = true;
            this.radFalse.Text = "False";
            this.radFalse.UseVisualStyleBackColor = true;
            this.radFalse.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(202, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 1);
            this.panel1.TabIndex = 25;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.ForeColor = System.Drawing.Color.White;
            this.txtAnswer.Location = new System.Drawing.Point(202, 395);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(622, 13);
            this.txtAnswer.TabIndex = 24;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(797, 594);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(202, 594);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 23);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblQuestNum
            // 
            this.lblQuestNum.AutoSize = true;
            this.lblQuestNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestNum.ForeColor = System.Drawing.Color.White;
            this.lblQuestNum.Location = new System.Drawing.Point(500, 594);
            this.lblQuestNum.Name = "lblQuestNum";
            this.lblQuestNum.Size = new System.Drawing.Size(32, 18);
            this.lblQuestNum.TabIndex = 28;
            this.lblQuestNum.Text = "0/0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(484, 615);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StudentQuizView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuestNum);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.radFalse);
            this.Controls.Add(this.radTrue);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblCourseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentQuizView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentQuizView";
            this.Load += new System.EventHandler(this.StudentQuizView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radTrue;
        private System.Windows.Forms.RadioButton radFalse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblQuestNum;
        private System.Windows.Forms.Button btnSubmit;
    }
}