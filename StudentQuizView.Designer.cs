﻿namespace IS_Team1_Project
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
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCourseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(418, 36);
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
            this.lblQuestion.Location = new System.Drawing.Point(456, 239);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(202, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 1);
            this.panel1.TabIndex = 25;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNum.ForeColor = System.Drawing.Color.White;
            this.txtStudentNum.Location = new System.Drawing.Point(202, 395);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(622, 13);
            this.txtStudentNum.TabIndex = 24;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(944, 594);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(100, 594);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 23);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // StudentQuizView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtStudentNum);
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
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}