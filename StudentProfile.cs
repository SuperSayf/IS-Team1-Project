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
                command.Parameters.AddWithValue("@student_num", LoginAdmin.AdminNum);
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
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("update admin set student_num = @student_num ,student_name = @student_name,student_surname = @student_surname,student_email= @student_email,student_password=@student_password", connection);
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
    }
}
