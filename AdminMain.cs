using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Team1_Project
{
    public partial class AdminMain : Form
    {
        private bool sidebarExpand;

        public AdminMain()
        {
            InitializeComponent();
        }

        public void loadform(object form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }

            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(fh);
            this.pnlMain.Tag = fh;
            fh.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new AdminHome());
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            loadform(new AdminCourses());
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            loadform(new AdminQuries());
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            loadform(new AdminProgress());
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            loadform(new AdminAcademic());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(new AdminProfile());
        }
    }
}