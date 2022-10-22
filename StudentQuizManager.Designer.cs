namespace IS_Team1_Project
{
    partial class StudentQuizManager
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.flpQueries = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnSendQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(133, 175);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(195, 18);
            this.lblText.TabIndex = 14;
            this.lblText.Text = "Pick a difficulty to begin";
            // 
            // btnEasy
            // 
            this.btnEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(171, 224);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(124, 38);
            this.btnEasy.TabIndex = 15;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Enabled = false;
            this.btnMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnMedium.ForeColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(171, 295);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(124, 38);
            this.btnMedium.TabIndex = 16;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Enabled = false;
            this.btnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(171, 366);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(124, 38);
            this.btnHard.TabIndex = 17;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCourseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(392, 32);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(202, 24);
            this.lblCourseName.TabIndex = 18;
            this.lblCourseName.Text = "Course Name Here";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCourseName.Click += new System.EventHandler(this.lblCourseName_Click);
            // 
            // flpQueries
            // 
            this.flpQueries.AutoScroll = true;
            this.flpQueries.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpQueries.Location = new System.Drawing.Point(598, 175);
            this.flpQueries.Name = "flpQueries";
            this.flpQueries.Size = new System.Drawing.Size(315, 182);
            this.flpQueries.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(592, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 1);
            this.panel1.TabIndex = 21;
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuery.ForeColor = System.Drawing.Color.White;
            this.txtQuery.Location = new System.Drawing.Point(592, 440);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(315, 13);
            this.txtQuery.TabIndex = 20;
            // 
            // btnSendQuery
            // 
            this.btnSendQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSendQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendQuery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendQuery.ForeColor = System.Drawing.Color.White;
            this.btnSendQuery.Location = new System.Drawing.Point(699, 478);
            this.btnSendQuery.Name = "btnSendQuery";
            this.btnSendQuery.Size = new System.Drawing.Size(110, 25);
            this.btnSendQuery.TabIndex = 22;
            this.btnSendQuery.Text = "Send";
            this.btnSendQuery.UseVisualStyleBackColor = true;
            this.btnSendQuery.Click += new System.EventHandler(this.btnSendQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(682, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Query responses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(696, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Send a query";
            // 
            // StudentQuizManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendQuery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.flpQueries);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentQuizManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentQuizManager";
            this.Load += new System.EventHandler(this.StudentQuizManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.FlowLayoutPanel flpQueries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnSendQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}