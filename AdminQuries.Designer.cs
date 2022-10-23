namespace IS_Team1_Project
{
    partial class AdminQuries
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSendHeader = new System.Windows.Forms.Label();
            this.btnSendAnswer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQueryAnswer = new System.Windows.Forms.TextBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplayUnresponded = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lblQuery);
            this.panel1.Location = new System.Drawing.Point(446, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblQuery
            // 
            this.lblQuery.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.ForeColor = System.Drawing.Color.White;
            this.lblQuery.Location = new System.Drawing.Point(0, 3);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(481, 100);
            this.lblQuery.TabIndex = 35;
            this.lblQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(648, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quries";
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Items.AddRange(new object[] {
            "COMS1015",
            "COMS2014",
            "COMS2002"});
            this.cmbCourses.Location = new System.Drawing.Point(118, 192);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(204, 21);
            this.cmbCourses.TabIndex = 25;
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select a course";
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(526, 257);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 31);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(805, 257);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 31);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSendHeader
            // 
            this.lblSendHeader.AutoSize = true;
            this.lblSendHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSendHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendHeader.ForeColor = System.Drawing.Color.White;
            this.lblSendHeader.Location = new System.Drawing.Point(608, 395);
            this.lblSendHeader.Name = "lblSendHeader";
            this.lblSendHeader.Size = new System.Drawing.Size(142, 18);
            this.lblSendHeader.TabIndex = 32;
            this.lblSendHeader.Text = "Send a response";
            // 
            // btnSendAnswer
            // 
            this.btnSendAnswer.Enabled = false;
            this.btnSendAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSendAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAnswer.ForeColor = System.Drawing.Color.White;
            this.btnSendAnswer.Location = new System.Drawing.Point(630, 477);
            this.btnSendAnswer.Name = "btnSendAnswer";
            this.btnSendAnswer.Size = new System.Drawing.Size(110, 25);
            this.btnSendAnswer.TabIndex = 31;
            this.btnSendAnswer.Text = "Send";
            this.btnSendAnswer.UseVisualStyleBackColor = true;
            this.btnSendAnswer.Click += new System.EventHandler(this.btnSendAnswer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(523, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 30;
            // 
            // txtQueryAnswer
            // 
            this.txtQueryAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtQueryAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQueryAnswer.ForeColor = System.Drawing.Color.White;
            this.txtQueryAnswer.Location = new System.Drawing.Point(523, 439);
            this.txtQueryAnswer.Name = "txtQueryAnswer";
            this.txtQueryAnswer.Size = new System.Drawing.Size(315, 13);
            this.txtQueryAnswer.TabIndex = 29;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Enabled = false;
            this.btnDisplayAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(155, 364);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(118, 25);
            this.btnDisplayAll.TabIndex = 33;
            this.btnDisplayAll.Text = "Display all quries";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDisplayUnresponded
            // 
            this.btnDisplayUnresponded.Enabled = false;
            this.btnDisplayUnresponded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDisplayUnresponded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayUnresponded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayUnresponded.ForeColor = System.Drawing.Color.White;
            this.btnDisplayUnresponded.Location = new System.Drawing.Point(118, 406);
            this.btnDisplayUnresponded.Name = "btnDisplayUnresponded";
            this.btnDisplayUnresponded.Size = new System.Drawing.Size(194, 25);
            this.btnDisplayUnresponded.TabIndex = 34;
            this.btnDisplayUnresponded.Text = "Display unresponded quries";
            this.btnDisplayUnresponded.UseVisualStyleBackColor = true;
            this.btnDisplayUnresponded.Click += new System.EventHandler(this.btnDisplayUnresponded_Click);
            // 
            // AdminQuries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.btnDisplayUnresponded);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.lblSendHeader);
            this.Controls.Add(this.btnSendAnswer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtQueryAnswer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminQuries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminQuries";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSendHeader;
        private System.Windows.Forms.Button btnSendAnswer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQueryAnswer;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplayUnresponded;
        private System.Windows.Forms.Label lblQuery;
    }
}