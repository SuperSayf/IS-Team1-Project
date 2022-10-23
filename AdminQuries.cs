using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Team1_Project
{
    public partial class AdminQuries : Form
    {
        private static ArrayList quries = new ArrayList();
        private static ArrayList quriesData = new ArrayList();
        private static int currQuery = 0;
        private static ArrayList student_numbers = new ArrayList();

        public AdminQuries()
        {
            InitializeComponent();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            quries.Clear();
            quriesData.Clear();
            student_numbers.Clear();
            currQuery = 0;

            String selectedCourse = cmbCourses.SelectedItem.ToString();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the queries table query_course is selectedCourse and query_answered is false
                OleDbCommand command = new OleDbCommand("SELECT * FROM queries WHERE query_course = @query_course AND query_answered = @query_answered", connection);
                command.Parameters.AddWithValue("@query_course", selectedCourse);
                command.Parameters.AddWithValue("@query_answered", false);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the questions to the array
                    quries.Add("Student Num: " + reader["student_num"].ToString() + "\n" + "Q: " + reader["query_question"].ToString());
                    quriesData.Add(reader["query_question"].ToString());
                    student_numbers.Add(reader["student_num"].ToString());
                }

                connection.Close();
            }

            if (quries.Count > 0)
            {
                btnNext.Enabled = true;
                btnSendAnswer.Enabled = true;
                btnDisplayAll.Enabled = true;
                btnDisplayUnresponded.Enabled = true;

                lblQuery.Text = quries[currQuery].ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnSendAnswer.Enabled = false;
                btnDisplayAll.Enabled = false;
                btnDisplayUnresponded.Enabled = false;
                btnPrev.Enabled = false;
                MessageBox.Show("There are no queries for this course");
            }

            if (quries.Count == 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currQuery++;
            if (currQuery < quries.Count)
            {
                lblQuery.Text = quries[currQuery].ToString();
            }

            if (currQuery == quries.Count - 1)
            {
                btnNext.Enabled = false;
            }

            if (currQuery > 0)
            {
                btnPrev.Enabled = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currQuery--;
            if (currQuery >= 0)
            {
                lblQuery.Text = quries[currQuery].ToString();
            }

            if (currQuery == 0)
            {
                btnPrev.Enabled = false;
            }

            if (currQuery < quries.Count)
            {
                btnNext.Enabled = true;
            }
        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            String selectedCourse = cmbCourses.SelectedItem.ToString();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to UPDATE the queries table where the student_num is the student number, and the query_question is the question, and the course is the selected course
                OleDbCommand command = new OleDbCommand("UPDATE queries SET query_answer = @query_answer, query_answered = @query_answered WHERE student_num = @student_num AND query_question = @query_question AND query_course = @query_course", connection);
                command.Parameters.AddWithValue("@query_answer", txtQueryAnswer.Text);
                command.Parameters.AddWithValue("@query_answered", true);
                command.Parameters.AddWithValue("@student_num", student_numbers[currQuery].ToString());
                command.Parameters.AddWithValue("@query_question", quriesData[currQuery].ToString());
                command.Parameters.AddWithValue("@query_course", selectedCourse);
                command.ExecuteNonQuery();

                connection.Close();
            }

            MessageBox.Show("Response sent");
            btnDisplayUnresponded_Click(sender, e);
            txtQueryAnswer.Clear();
        }

        private void btnDisplayUnresponded_Click(object sender, EventArgs e)
        {
            quries.Clear();
            quriesData.Clear();
            student_numbers.Clear();
            currQuery = 0;
            btnPrev.Enabled = false;

            lblSendHeader.Text = "Send a response";
            btnSendAnswer.Text = "Send";

            String selectedCourse = cmbCourses.SelectedItem.ToString();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the queries table query_course is selectedCourse and query_answered is false
                OleDbCommand command = new OleDbCommand("SELECT * FROM queries WHERE query_course = @query_course AND query_answered = @query_answered", connection);
                command.Parameters.AddWithValue("@query_course", selectedCourse);
                command.Parameters.AddWithValue("@query_answered", false);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the questions to the array
                    quries.Add("Student Num: " + reader["student_num"].ToString() + "\n" + "Q: " + reader["query_question"].ToString());
                    quriesData.Add(reader["query_question"].ToString());
                    student_numbers.Add(reader["student_num"].ToString());
                }

                connection.Close();
            }

            if (quries.Count > 0)
            {
                btnNext.Enabled = true;
                btnSendAnswer.Enabled = true;
                btnDisplayAll.Enabled = true;
                btnDisplayUnresponded.Enabled = true;

                lblQuery.Text = quries[currQuery].ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnSendAnswer.Enabled = false;
                btnDisplayAll.Enabled = false;
                btnDisplayUnresponded.Enabled = false;
                MessageBox.Show("There are no queries for this course");
            }

            if (quries.Count == 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            quries.Clear();
            quriesData.Clear();
            student_numbers.Clear();
            currQuery = 0;
            btnPrev.Enabled = false;
            lblSendHeader.Text = "Send/Change a response";
            btnSendAnswer.Text = "Send/Change";

            String selectedCourse = cmbCourses.SelectedItem.ToString();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the queries table query_course is selectedCourse and query_answered is false
                OleDbCommand command = new OleDbCommand("SELECT * FROM queries WHERE query_course = @query_course", connection);
                command.Parameters.AddWithValue("@query_course", selectedCourse);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the questions to the array
                    quries.Add("Student Num: " + reader["student_num"].ToString() + "\n" + "Q: " + reader["query_question"].ToString() + "\n" + "A: " + reader["query_answer"].ToString());
                    quriesData.Add(reader["query_question"].ToString());
                    student_numbers.Add(reader["student_num"].ToString());
                }

                connection.Close();
            }

            if (quries.Count > 0)
            {
                btnNext.Enabled = true;
                btnSendAnswer.Enabled = true;
                btnDisplayAll.Enabled = true;
                btnDisplayUnresponded.Enabled = true;

                lblQuery.Text = quries[currQuery].ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnSendAnswer.Enabled = false;
                btnDisplayAll.Enabled = false;
                btnDisplayUnresponded.Enabled = false;
                MessageBox.Show("There are no queries for this course");
            }

            if (quries.Count == 1)
            {
                btnNext.Enabled = false;
            }
        }
    }
}