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
using System.Xml.Linq;
using System.IO;
using System.Data.OleDb;

namespace IS_Team1_Project
{
    public partial class frmLogin : Form
    {
        // Database Paths - Comment out everyone elses except yours

        //Sayf
        //public static String dbPath = @"C:\Users\ACER PREDATOR 300\Desktop\Projects\IS-Team1-Project\database.accdb";

        // Mu'aaz
        // public static String dbPath = @"";
        // Muz
         public static String dbPath = @"C:\Users\sakhi\Desktop\Coding\IS\IS-Team1-Project\database.accdb";
        // Miguel
        // public static String dbPath = @"";
        // Pratham
        // public static String dbPath = @"";
        // Daggy
         //public static String dbPath = @"C:\Users\momos\Documents\GitHub\IS-Team1-Project\database.accdb";

        public static string StudentNum;

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

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;

            if (TxtStudentNum_Validating(sender, new CancelEventArgs()) && TxtPassword_Validating(sender, new CancelEventArgs()))
            {
                // Check if the student number and password match
                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM students WHERE student_num = @student_num AND student_password = @student_password", connection);
                    command.Parameters.AddWithValue("@student_num", txtStudentNum.Text);
                    command.Parameters.AddWithValue("@student_password", txtPassword.Text);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // If the student number and password match, then open the student dashboard
                        StudentNum = txtStudentNum.Text;
                        StudentMain studentMain = new StudentMain();
                        studentMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid student number or password");
                    }
                    connection.Close();
                }
            }
        }

        private bool TxtStudentNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNum.Text))
            {
                e.Cancel = true;
                txtStudentNum.Focus();
                errorProvider2.SetError(txtStudentNum, "Enter Student Number");

                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtStudentNum, "");
                return true;
            }
        }

        private bool TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider2.SetError(txtPassword, "Enter password");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPassword, "");
                return true;
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            StudentRegister studentRegister = new StudentRegister();
            studentRegister.Show();
            this.Hide();
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