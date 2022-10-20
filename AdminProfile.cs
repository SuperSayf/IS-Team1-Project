using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Team1_Project
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM admin WHERE admin_num = @admin_num" , connection);
                command.Parameters.AddWithValue("@admin_num", LoginAdmin.AdminNum);  
                // We basically read from the databse and set the textboxes text to their respective text
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtboxAdminNo.Text = reader["admin_num"].ToString();
                    txtboxEmail.Text  = reader["admin_email"].ToString();
                    txtboxFirstName.Text = reader["admin_name"].ToString();
                    txtBoxLastName.Text = reader["admin_surname"].ToString();
                    txtboxPassword.Text  = reader["admin_password"].ToString();

                }    
                connection.Close();

            }

                
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAdminNo.Clear();
            txtboxEmail.Clear();
            txtboxFirstName.Clear();
            txtBoxLastName.Clear();
            txtboxPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("update admin set admin_num = @admin_num ,admin_name= @admin_name,admin_surname = @adminsurname,admin_email= @admin_email,admin_password=@admin_password", connection);
                command.Parameters.AddWithValue("@admin_num", txtboxAdminNo.Text);
                command.Parameters.AddWithValue("@admin_name", txtboxFirstName.Text);
                command.Parameters.AddWithValue("@admin_surname", txtBoxLastName.Text);
                command.Parameters.AddWithValue("@admin_email", txtboxEmail.Text);
                command.Parameters.AddWithValue("@admin_password", txtboxPassword.Text);
                command.ExecuteNonQuery();
                connection.Close();
                
                MessageBox.Show("Profile updated");


            }
        }
    }
}
