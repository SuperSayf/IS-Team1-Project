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
        private static String course1 = "";
        private static String course2 = "";
        public static String selectedCourse = "";

        public StudentCourses()
        {
            InitializeComponent();
        }

        private void StudentCourses_Load(object sender, EventArgs e)
        {
            bool bEnrolled = true;
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
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
                    bEnrolled = reader["course_enrolled"] as bool? ?? false;

                    if (bEnrolled)
                    {
                        // If enrolled is true
                        lblHeader.Visible = true;
                        pnl1.Visible = true;
                        pnl2.Visible = true;

                        // Set the text on the panels to the course name
                        course1 = reader["course_1"].ToString();
                        course2 = reader["course_2"].ToString();

                        lblCourseName1.Text = course1;
                        lblCourseName2.Text = course2;

                        // SQL to count how many students in the table have the same course
                        OleDbCommand command2 = new OleDbCommand("SELECT COUNT(*) FROM courses WHERE course_1 = @course_1", connection);
                        command2.Parameters.AddWithValue("@course_1", course1);
                        OleDbDataReader reader2 = command2.ExecuteReader();
                        if (reader2.Read())
                        {
                            // Set the text on the panels to the number of students in the course
                            int course1Count = reader2.GetInt32(0) - 1;
                            lblC1Students.Text = course1Count.ToString() + " other student(s) in your class";
                        }

                        OleDbCommand command3 = new OleDbCommand("SELECT COUNT(*) FROM courses WHERE course_2 = @course_2", connection);
                        command3.Parameters.AddWithValue("@course_2", course2);
                        OleDbDataReader reader3 = command3.ExecuteReader();
                        if (reader3.Read())
                        {
                            int course2Count = reader3.GetInt32(0) - 1;
                            lblC2Students.Text = course2Count.ToString() + " other student(s) in your class";
                        }
                    }
                    else
                    {
                        lblSelectCourses.Visible = true;
                        cboCourse1.Visible = true;
                        cboCourse2.Visible = true;
                        btnConfirmCourse.Visible = true;
                    }
                }
                connection.Close();
            }
        }

        private void btnConfirmCourse_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            string Course1, Course2;
            Course1 = cboCourse1.Text;
            Course2 = cboCourse2.Text;
            //Course1 = cboCourse1.SelectedValue.ToString();
            //Course2 = cboCourse2.SelectedValue.ToString();
            if ((Course1 == Course2) && !(Course1 == "" || Course2 == ""))
            {
                MessageBox.Show("You can't select the same course twice");
            }
            else if (Course1 == "" || Course2 == "")
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

        private void pnl1_Click(object sender, EventArgs e)
        {
            selectedCourse = course1;
            StudentMain.loadform(new StudentQuizManager());
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            selectedCourse = course2;
            StudentMain.loadform(new StudentQuizManager());
        }

        private void pnl1_MouseEnter(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void pnl1_MouseLeave(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(16, 25, 56);
        }

        private void pnl2_MouseEnter(object sender, EventArgs e)
        {
            pnl2.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void pnl2_MouseLeave(object sender, EventArgs e)
        {
            pnl2.BackColor = Color.FromArgb(16, 25, 56);
        }

        private void lblCourseName1_MouseEnter(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblC1Academic_MouseEnter(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblC1Students_MouseEnter(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblCourseName2_MouseEnter(object sender, EventArgs e)
        {
            pnl2.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblC2Academic_MouseEnter(object sender, EventArgs e)
        {
            pnl2.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblC2Students_MouseEnter(object sender, EventArgs e)
        {
            pnl2.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lblCourseName1_Click(object sender, EventArgs e)
        {
            pnl1_Click(sender, e);
        }

        private void lblC1Academic_Click(object sender, EventArgs e)
        {
            pnl1_Click(sender, e);
        }

        private void lblC1Students_Click(object sender, EventArgs e)
        {
            pnl1_Click(sender, e);
        }

        private void lblCourseName2_Click(object sender, EventArgs e)
        {
            pnl2_Click(sender, e);
        }

        private void lblC2Academic_Click(object sender, EventArgs e)
        {
            pnl2_Click(sender, e);
        }

        private void lblC2Students_Click(object sender, EventArgs e)
        {
            pnl2_Click(sender, e);
        }
    }
}