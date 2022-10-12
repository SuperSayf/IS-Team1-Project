using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Team1_Project
{
    public partial class StudentRegister : Form
    {
        
        
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

        public StudentRegister()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");

            // If all validations are passed, then register the student to the database
            if (TxtStudentNo_Validating(sender, new CancelEventArgs()) && TxtEmail_Validating(sender, new CancelEventArgs()) && TxtName_Validating(txtName, new CancelEventArgs()) && TxtSurname_Validating(txtSurname, new CancelEventArgs()) && TxtPassword_Validating(txtPassword, new CancelEventArgs()) && TxtConfirm_Validating(txtConfirmPassword, new CancelEventArgs()))
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {

                    using (OleDbConnection connection = new OleDbConnection(connectionstring))
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand("INSERT INTO courses (student_num) VALUES (@student_num)", connection);
                        command.Parameters.AddWithValue("@student_num", txtStudentNo.Text);
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    using (OleDbConnection connection = new OleDbConnection(connectionstring))
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand("INSERT INTO students (student_num, student_email, student_name, student_surname, student_password) VALUES (@student_num, @student_email, @student_name, @student_surname, @student_password)", connection);
                        command.Parameters.AddWithValue("@student_num", txtStudentNo.Text);
                        command.Parameters.AddWithValue("@student_email", txtEmail.Text);
                        command.Parameters.AddWithValue("@student_name", txtName.Text);
                        command.Parameters.AddWithValue("@student_surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@student_password", txtPassword.Text);
                        command.ExecuteNonQuery();
                        connection.Close();               
                        MessageBox.Show("Student registered successfully");
                        frmLogin studentLogin = new frmLogin();
                        studentLogin.Show();
                        this.Close();
                        
                    }
                }
            }
        }

        private bool TxtStudentNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtStudentNo.Text.Length != 7)
            {
                e.Cancel = true;
                txtStudentNo.Focus();
                errorProvider1.SetError(txtStudentNo, "Student number must be 7 digits");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtStudentNo, "");
                return true;
            }
        }

        private bool TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider2.SetError(txtName, "Enter First Name");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtName, "");
                return true;
            }
        }

        private bool TxtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                e.Cancel = true;
                txtSurname.Focus();
                errorProvider3.SetError(txtSurname, "Enter Last Name");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtSurname, "");
                return true;
            }
        }

        private bool TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !rEMail.IsMatch(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider4.SetError(txtEmail, "Enter a valid email address");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtEmail, "");
                return true;
            }
        }

        private bool TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider4.SetError(txtPassword, "Password should not be left blank!");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtPassword, "");
                return true;
            }
        }

        private bool TxtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider5.SetError(txtConfirmPassword, " Confirm Password");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(txtConfirmPassword, "");
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentNo.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Minimize the application
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Minimize the application
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}