namespace IS_Team1_Project
{
    partial class AdminMain
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCourses = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnQueries = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnProgress = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnAcademic = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(187, 676);
            this.sidebar.MinimumSize = new System.Drawing.Size(77, 676);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(77, 676);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::IS_Team1_Project.Properties.Resources.icons8_menu_24;
            this.btnMenu.Location = new System.Drawing.Point(25, 37);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(26, 26);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::IS_Team1_Project.Properties.Resources.icons8_home_24__1_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-11, -11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(223, 57);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "                  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(3, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 51);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCourses);
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 46);
            this.panel5.TabIndex = 4;
            // 
            // btnCourses
            // 
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = global::IS_Team1_Project.Properties.Resources.icons8_books_24;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(-11, -11);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(223, 62);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "                  Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(3, 218);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 46);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnQueries);
            this.panel9.Location = new System.Drawing.Point(8, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 46);
            this.panel9.TabIndex = 4;
            // 
            // btnQueries
            // 
            this.btnQueries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueries.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.ForeColor = System.Drawing.Color.White;
            this.btnQueries.Image = global::IS_Team1_Project.Properties.Resources.icons8_topic_24;
            this.btnQueries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueries.Location = new System.Drawing.Point(-11, -8);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQueries.Size = new System.Drawing.Size(223, 51);
            this.btnQueries.TabIndex = 3;
            this.btnQueries.Text = "                  Queries";
            this.btnQueries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(3, 270);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 46);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnProgress);
            this.panel11.Location = new System.Drawing.Point(8, 8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 46);
            this.panel11.TabIndex = 4;
            // 
            // btnProgress
            // 
            this.btnProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.ForeColor = System.Drawing.Color.White;
            this.btnProgress.Image = global::IS_Team1_Project.Properties.Resources.icons8_progress_24;
            this.btnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.Location = new System.Drawing.Point(-11, -8);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProgress.Size = new System.Drawing.Size(223, 51);
            this.btnProgress.TabIndex = 3;
            this.btnProgress.Text = "                  Progress";
            this.btnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(3, 322);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 46);
            this.panel12.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnAcademic);
            this.panel13.Location = new System.Drawing.Point(8, 8);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 46);
            this.panel13.TabIndex = 4;
            // 
            // btnAcademic
            // 
            this.btnAcademic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcademic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademic.ForeColor = System.Drawing.Color.White;
            this.btnAcademic.Image = global::IS_Team1_Project.Properties.Resources.icons8_mortarboard_24;
            this.btnAcademic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcademic.Location = new System.Drawing.Point(-11, -11);
            this.btnAcademic.Name = "btnAcademic";
            this.btnAcademic.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAcademic.Size = new System.Drawing.Size(223, 57);
            this.btnAcademic.TabIndex = 3;
            this.btnAcademic.Text = "                  Academic";
            this.btnAcademic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcademic.UseVisualStyleBackColor = true;
            this.btnAcademic.Click += new System.EventHandler(this.btnAcademic_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 374);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 46);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnProfile);
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 46);
            this.panel7.TabIndex = 4;
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::IS_Team1_Project.Properties.Resources.icons8_user_24;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-11, -8);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(223, 54);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "                  Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(77, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 676);
            this.pnlMain.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::IS_Team1_Project.Properties.Resources.icons8_subtract_15;
            this.btnMinimize.Location = new System.Drawing.Point(1100, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 17);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::IS_Team1_Project.Properties.Resources.icons8_close_15;
            this.btnClose.Location = new System.Drawing.Point(1130, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 17);
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1157, 676);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnAcademic;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnProfile;
    }
}