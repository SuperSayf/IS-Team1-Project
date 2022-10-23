namespace IS_Team1_Project
{
    partial class StudentCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblC1Students = new System.Windows.Forms.Label();
            this.lblC1Academic = new System.Windows.Forms.Label();
            this.lblCourseName1 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblC2Students = new System.Windows.Forms.Label();
            this.lblC2Academic = new System.Windows.Forms.Label();
            this.lblCourseName2 = new System.Windows.Forms.Label();
            this.cboCourse1 = new System.Windows.Forms.ComboBox();
            this.cboCourse2 = new System.Windows.Forms.ComboBox();
            this.btnConfirmCourse = new System.Windows.Forms.Button();
            this.lblSelectCourses = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.lblC1Students);
            this.pnl1.Controls.Add(this.lblC1Academic);
            this.pnl1.Controls.Add(this.lblCourseName1);
            this.pnl1.ForeColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(98, 213);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(385, 261);
            this.pnl1.TabIndex = 2;
            this.pnl1.Visible = false;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            this.pnl1.MouseEnter += new System.EventHandler(this.pnl1_MouseEnter);
            this.pnl1.MouseLeave += new System.EventHandler(this.pnl1_MouseLeave);
            // 
            // lblC1Students
            // 
            this.lblC1Students.AutoSize = true;
            this.lblC1Students.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1Students.ForeColor = System.Drawing.Color.White;
            this.lblC1Students.Location = new System.Drawing.Point(21, 188);
            this.lblC1Students.Name = "lblC1Students";
            this.lblC1Students.Size = new System.Drawing.Size(150, 26);
            this.lblC1Students.TabIndex = 5;
            this.lblC1Students.Text = "100 students";
            this.lblC1Students.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblC1Students.Click += new System.EventHandler(this.lblC1Students_Click);
            this.lblC1Students.MouseEnter += new System.EventHandler(this.lblC1Students_MouseEnter);
            // 
            // lblC1Academic
            // 
            this.lblC1Academic.AutoSize = true;
            this.lblC1Academic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1Academic.ForeColor = System.Drawing.Color.White;
            this.lblC1Academic.Location = new System.Drawing.Point(87, 116);
            this.lblC1Academic.Name = "lblC1Academic";
            this.lblC1Academic.Size = new System.Drawing.Size(175, 28);
            this.lblC1Academic.TabIndex = 3;
            this.lblC1Academic.Text = "Lecturer Here";
            this.lblC1Academic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC1Academic.Click += new System.EventHandler(this.lblC1Academic_Click);
            this.lblC1Academic.MouseEnter += new System.EventHandler(this.lblC1Academic_MouseEnter);
            // 
            // lblCourseName1
            // 
            this.lblCourseName1.AutoSize = true;
            this.lblCourseName1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName1.ForeColor = System.Drawing.Color.White;
            this.lblCourseName1.Location = new System.Drawing.Point(111, 37);
            this.lblCourseName1.Name = "lblCourseName1";
            this.lblCourseName1.Size = new System.Drawing.Size(116, 28);
            this.lblCourseName1.TabIndex = 2;
            this.lblCourseName1.Text = "Course 1";
            this.lblCourseName1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCourseName1.Click += new System.EventHandler(this.lblCourseName1_Click);
            this.lblCourseName1.MouseEnter += new System.EventHandler(this.lblCourseName1_MouseEnter);
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.lblC2Students);
            this.pnl2.Controls.Add(this.lblC2Academic);
            this.pnl2.Controls.Add(this.lblCourseName2);
            this.pnl2.Location = new System.Drawing.Point(556, 213);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(385, 261);
            this.pnl2.TabIndex = 3;
            this.pnl2.Visible = false;
            this.pnl2.Click += new System.EventHandler(this.pnl2_Click);
            this.pnl2.MouseEnter += new System.EventHandler(this.pnl2_MouseEnter);
            this.pnl2.MouseLeave += new System.EventHandler(this.pnl2_MouseLeave);
            // 
            // lblC2Students
            // 
            this.lblC2Students.AutoSize = true;
            this.lblC2Students.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC2Students.ForeColor = System.Drawing.Color.White;
            this.lblC2Students.Location = new System.Drawing.Point(31, 188);
            this.lblC2Students.Name = "lblC2Students";
            this.lblC2Students.Size = new System.Drawing.Size(150, 26);
            this.lblC2Students.TabIndex = 6;
            this.lblC2Students.Text = "100 students";
            this.lblC2Students.Click += new System.EventHandler(this.lblC2Students_Click);
            this.lblC2Students.MouseEnter += new System.EventHandler(this.lblC2Students_MouseEnter);
            // 
            // lblC2Academic
            // 
            this.lblC2Academic.AutoSize = true;
            this.lblC2Academic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC2Academic.ForeColor = System.Drawing.Color.White;
            this.lblC2Academic.Location = new System.Drawing.Point(95, 116);
            this.lblC2Academic.Name = "lblC2Academic";
            this.lblC2Academic.Size = new System.Drawing.Size(175, 28);
            this.lblC2Academic.TabIndex = 4;
            this.lblC2Academic.Text = "Lecturer Here";
            this.lblC2Academic.Click += new System.EventHandler(this.lblC2Academic_Click);
            this.lblC2Academic.MouseEnter += new System.EventHandler(this.lblC2Academic_MouseEnter);
            // 
            // lblCourseName2
            // 
            this.lblCourseName2.AutoSize = true;
            this.lblCourseName2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName2.ForeColor = System.Drawing.Color.White;
            this.lblCourseName2.Location = new System.Drawing.Point(117, 37);
            this.lblCourseName2.Name = "lblCourseName2";
            this.lblCourseName2.Size = new System.Drawing.Size(116, 28);
            this.lblCourseName2.TabIndex = 3;
            this.lblCourseName2.Text = "Course 2";
            this.lblCourseName2.Click += new System.EventHandler(this.lblCourseName2_Click);
            this.lblCourseName2.MouseEnter += new System.EventHandler(this.lblCourseName2_MouseEnter);
            // 
            // cboCourse1
            // 
            this.cboCourse1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboCourse1.FormattingEnabled = true;
            this.cboCourse1.Items.AddRange(new object[] {
            "INFO2001A",
            "INFO2000A",
            "COMS2014A"});
            this.cboCourse1.Location = new System.Drawing.Point(357, 106);
            this.cboCourse1.Margin = new System.Windows.Forms.Padding(2);
            this.cboCourse1.Name = "cboCourse1";
            this.cboCourse1.Size = new System.Drawing.Size(127, 26);
            this.cboCourse1.TabIndex = 4;
            this.cboCourse1.Visible = false;
            // 
            // cboCourse2
            // 
            this.cboCourse2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboCourse2.FormattingEnabled = true;
            this.cboCourse2.Items.AddRange(new object[] {
            "INFO2001A",
            "INFO2000A",
            "COMS2014A"});
            this.cboCourse2.Location = new System.Drawing.Point(556, 106);
            this.cboCourse2.Margin = new System.Windows.Forms.Padding(2);
            this.cboCourse2.Name = "cboCourse2";
            this.cboCourse2.Size = new System.Drawing.Size(127, 26);
            this.cboCourse2.TabIndex = 5;
            this.cboCourse2.Visible = false;
            // 
            // btnConfirmCourse
            // 
            this.btnConfirmCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCourse.Location = new System.Drawing.Point(444, 158);
            this.btnConfirmCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmCourse.Name = "btnConfirmCourse";
            this.btnConfirmCourse.Size = new System.Drawing.Size(147, 25);
            this.btnConfirmCourse.TabIndex = 6;
            this.btnConfirmCourse.Text = "Confirm Courses";
            this.btnConfirmCourse.UseVisualStyleBackColor = true;
            this.btnConfirmCourse.Visible = false;
            this.btnConfirmCourse.Click += new System.EventHandler(this.btnConfirmCourse_Click);
            // 
            // lblSelectCourses
            // 
            this.lblSelectCourses.AutoSize = true;
            this.lblSelectCourses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourses.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourses.Location = new System.Drawing.Point(434, 73);
            this.lblSelectCourses.Name = "lblSelectCourses";
            this.lblSelectCourses.Size = new System.Drawing.Size(200, 18);
            this.lblSelectCourses.TabIndex = 7;
            this.lblSelectCourses.Text = "Please Select 2 courses";
            this.lblSelectCourses.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(459, 138);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(114, 18);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Your courses";
            this.lblHeader.Visible = false;
            // 
            // StudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSelectCourses);
            this.Controls.Add(this.btnConfirmCourse);
            this.Controls.Add(this.cboCourse2);
            this.Controls.Add(this.cboCourse1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentCourses";
            this.Load += new System.EventHandler(this.StudentCourses_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblC1Academic;
        private System.Windows.Forms.Label lblCourseName1;
        private System.Windows.Forms.Label lblC2Academic;
        private System.Windows.Forms.Label lblCourseName2;
        private System.Windows.Forms.Label lblC1Students;
        private System.Windows.Forms.Label lblC2Students;
        private System.Windows.Forms.ComboBox cboCourse1;
        private System.Windows.Forms.ComboBox cboCourse2;
        private System.Windows.Forms.Button btnConfirmCourse;
        private System.Windows.Forms.Label lblSelectCourses;
        private System.Windows.Forms.Label lblHeader;
    }
}