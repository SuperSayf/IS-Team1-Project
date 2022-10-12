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
    public partial class StudentCourses : Form
    {
        public StudentCourses()
        {
            InitializeComponent();
        }

        private void StudentCourses_Load(object sender, EventArgs e)
        {
            bool bEnrolled = false;
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM courses WHERE student_num = @student_num AND course_enrolled = @course_enrolled", connection);
                command.Parameters.AddWithValue("@student_num", frmLogin.StudentNum);
                command.Parameters.AddWithValue("@course_enrolled", bEnrolled);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // If enrolled is false
                    lblSelectCourses.Visible = true;
                    cboCourse1.Visible = true;
                    cboCourse2.Visible = true;
                    btnConfirmCourse.Visible = true;
                }
                else
                {
                    // If enrolled is true
                    pnl1.Visible = true;
                    pnl2.Visible = true;
                }
                connection.Close();
            }
        }

        private void btnConfirmCourse_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.accdb");

            string Course1, Course2;
            Course1 = cboCourse1.Text;
            Course2 = cboCourse2.Text;
            //Course1 = cboCourse1.SelectedValue.ToString();
            //Course2 = cboCourse2.SelectedValue.ToString();
            if ((Course1 == Course2) && !(Course1 == "" || Course2 == ""))
            {
                MessageBox.Show("You can't select the same course twice");
            }
            else if (Course1 =="" || Course2=="")
            {
                MessageBox.Show("You have to select a course");
            }
            else
            {
                lblSelectCourses.Visible = false;
                cboCourse1.Visible = false;
                cboCourse2.Visible = false;
                btnConfirmCourse.Visible = false;
                pnl1.Visible = true;
                pnl2.Visible = true;

                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE courses set course_1=@Course1, course_2=@Course2, course_enrolled = true WHERE student_num = @student_num", connection);
                    command.Parameters.AddWithValue("@Course1", Course1);
                    command.Parameters.AddWithValue("@Course2", Course2);
                    command.Parameters.AddWithValue("@student_num", frmLogin.StudentNum);
                    command.ExecuteNonQuery();
                    connection.Close();

                }

            }
        }
    }
}
