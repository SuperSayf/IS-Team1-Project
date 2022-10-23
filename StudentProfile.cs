using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace IS_Team1_Project
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM students WHERE student_num = @student_num", connection);
                command.Parameters.AddWithValue("@student_num", frmLogin.StudentNum);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtboxStudentNo.Text = reader["student_num"].ToString();
                    txtboxEmail.Text = reader["student_email"].ToString();
                    txtboxFirstName.Text = reader["student_name"].ToString();
                    txtBoxLastName.Text = reader["student_surname"].ToString();
                    txtboxPassword.Text = reader["student_password"].ToString();
                }
                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxFirstName.Clear();
            txtBoxLastName.Clear();
            txtboxPassword.Clear();
            txtboxEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtStudentNo_Validating(sender, new CancelEventArgs()) && TxtEmail_Validating(txtboxEmail, new CancelEventArgs()) && TxtName_Validating(txtboxFirstName, new CancelEventArgs()) && TxtSurname_Validating(txtBoxLastName, new CancelEventArgs()) && TxtPassword_Validating(txtboxPassword, new CancelEventArgs()))
            {
                string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("Update students set student_num = @student_num ,student_name = @student_name,student_surname = @student_surname,student_email= @student_email,student_password=@student_password where student_num=@student_num", connection);
                    command.Parameters.AddWithValue("@student_num", txtboxStudentNo.Text);
                    command.Parameters.AddWithValue("@student_name", txtboxFirstName.Text);
                    command.Parameters.AddWithValue("@student_surname", txtBoxLastName.Text);
                    command.Parameters.AddWithValue("@student_email", txtboxEmail.Text);
                    command.Parameters.AddWithValue("@student_password", txtboxPassword.Text);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Profile updated");
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtboxPassword.PasswordChar = '\0';
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtboxPassword.PasswordChar = '*';
            }
        }
        private bool TxtStudentNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtboxStudentNo.Text.Length != 7)
            {
                e.Cancel = true;
                txtboxStudentNo.Focus();
                errorProvider1.SetError(txtboxStudentNo, "Student number must be 7 digits");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtboxStudentNo, "");
                return true;
            }
        }

        private bool TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFirstName.Text))
            {
                e.Cancel = true;
                txtboxFirstName.Focus();
                errorProvider2.SetError(txtboxFirstName, "Enter First Name");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtboxFirstName, "");
                return true;
            }
        }

        private bool TxtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                e.Cancel = true;
                txtBoxLastName.Focus();
                errorProvider3.SetError(txtBoxLastName, "Enter Last Name");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtBoxLastName, "");
                return true;
            }
        }

        private bool TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (string.IsNullOrWhiteSpace(txtboxEmail.Text) || !rEMail.IsMatch(txtboxEmail.Text))
            {
                e.Cancel = true;
                txtboxEmail.Focus();
                errorProvider4.SetError(txtboxEmail, "Enter a valid email address");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtboxEmail, "");
                return true;
            }
        }

        private bool TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                e.Cancel = true;
                txtboxPassword.Focus();
                errorProvider4.SetError(txtboxPassword, "Password should not be left blank!");
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtboxPassword, "");
                return true;
            }
        }
    }
}