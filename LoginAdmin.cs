using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;

namespace IS_Team1_Project
{
    public partial class LoginAdmin : Form

    {
        public static string AdminNum;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public LoginAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            if (TxtStudentNum_Validating(sender, new CancelEventArgs()) && TxtPassword_Validating(sender, new CancelEventArgs()))
            {
                // Check if the admin number and password match
                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM admin WHERE admin_num = @admin_num AND admin_password = @admin_password", connection);
                    command.Parameters.AddWithValue("@admin_num", txtAdminNum.Text);
                    command.Parameters.AddWithValue("@admin_password", txtAdminPassword.Text);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // If the admin number and password match, then open the admin dashboard
                        AdminNum = txtAdminNum.Text;
                        AdminMain adminMain = new AdminMain();
                        adminMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid admin number or password");
                    }
                    connection.Close();
                }
            }
        }

        private bool TxtStudentNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminNum.Text))
            {
                e.Cancel = true;
                txtAdminNum.Focus();

                errorProvider2.SetError(txtAdminNum, "Enter Admin Number");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAdminNum, "");
                return true;
            }
        }

        private bool TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                e.Cancel = true;
                txtAdminPassword.Focus();

                errorProvider2.SetError(txtAdminPassword, "Enter password");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAdminPassword, "");
                return true;
            }
        }

        private void lblStudent_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Minimize the application
            this.WindowState = FormWindowState.Minimized;
        }
    }
}