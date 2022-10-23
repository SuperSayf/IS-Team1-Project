using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IS_Team1_Project
{
    public partial class StudentQuizManager : Form
    {
        public static String quizDifficulty = "";

        public StudentQuizManager()
        {
            InitializeComponent();
        }

        private void StudentQuizManager_Load(object sender, EventArgs e)
        {
            // Set the course header
            lblCourseName.Text = StudentCourses.selectedCourse;

            // Fetch database info
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the queries table the query_answered is true and query_course is selectedCourse
                OleDbCommand command = new OleDbCommand("SELECT * FROM queries WHERE query_answered = @query_answered AND query_course = @query_course", connection);
                command.Parameters.AddWithValue("@query_answered", true);
                command.Parameters.AddWithValue("@query_course", StudentCourses.selectedCourse);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Dynamically adds the query_answer as a panel to the FlowLayout panel
                    Panel panel = new Panel();
                    panel.Size = new Size(315, 150);
                    panel.BackColor = Color.FromArgb(10, 20, 56);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Margin = new Padding(0, 0, 0, 0);
                    panel.Padding = new Padding(0, 0, 0, 0);
                    panel.Name = reader["query_answer"].ToString();

                    Label lblQuery = new Label();
                    lblQuery.Text = "Q: " + reader["query_question"].ToString() + "\n\n" + "A: " + reader["query_answer"].ToString();
                    lblQuery.ForeColor = Color.White;
                    lblQuery.Font = new Font("Microsoft Sans Serif", 12);
                    lblQuery.Location = new Point(10, 10);
                    lblQuery.AutoSize = true;
                    lblQuery.MaximumSize = new Size(300, 0);
                    lblQuery.Name = "lblQuery";
                    panel.Controls.Add(lblQuery);

                    // Add the panel to the flowlayout panel
                    flpQueries.Controls.Add(panel);
                }

                connection.Close();
            }

            int HighestEasy = 0;
            int HighestMedium = 0;
            int HighestHard = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the quiz table quiz_pass is true and quiz_course is selectedCourse
                OleDbCommand command = new OleDbCommand("SELECT * FROM quiz WHERE quiz_pass = @quiz_pass AND quiz_course = @quiz_course", connection);
                command.Parameters.AddWithValue("@quiz_pass", true);
                command.Parameters.AddWithValue("@quiz_course", StudentCourses.selectedCourse);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["quiz_difficulty"].ToString() == "Easy")
                    {
                        btnMedium.Enabled = true;

                        int score = Convert.ToInt32(reader["quiz_score"].ToString());
                        if (score >= HighestEasy)
                        {
                            HighestEasy = score;
                            lblEasyHigh.Text = "Your best pass: " + HighestEasy.ToString() + "/10";
                            trackEasy.Value = HighestEasy;
                        }
                    }

                    if (reader["quiz_difficulty"].ToString() == "Medium")
                    {
                        btnHard.Enabled = true;

                        int score = Convert.ToInt32(reader["quiz_score"].ToString());
                        if (score >= HighestMedium)
                        {
                            HighestMedium = score;
                            lblMediumHigh.Text = "Your best pass: " + HighestMedium.ToString() + "/10";
                            trackMedium.Value = HighestMedium;
                        }
                    }

                    if (reader["quiz_difficulty"].ToString() == "Hard")
                    {
                        int score = Convert.ToInt32(reader["quiz_score"].ToString());
                        if (score >= HighestHard)
                        {
                            HighestHard = score;
                            lblHardHigh.Text = "Your best pass: " + HighestHard.ToString() + "/10";
                            trackHard.Value = HighestHard;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            quizDifficulty = "Easy";
            StudentMain.loadform(new StudentQuizView());
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            quizDifficulty = "Medium";
            StudentMain.loadform(new StudentQuizView());
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            quizDifficulty = "Hard";
            StudentMain.loadform(new StudentQuizView());
        }

        private void btnSendQuery_Click(object sender, EventArgs e)
        {
            // Validate if txtQuery is not empty
            if (txtQuery.Text != "")
            {
                // Add to database
                string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    // SQL to insert into queries student_num and query_question
                    OleDbCommand command = new OleDbCommand("INSERT INTO queries (student_num, query_question, query_course) VALUES (@student_num, @query_question, @query_course)", connection);
                    command.Parameters.AddWithValue("@student_num", frmLogin.StudentNum);
                    command.Parameters.AddWithValue("@query_question", txtQuery.Text);
                    command.Parameters.AddWithValue("@query_course", StudentCourses.selectedCourse);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                // Clear the txtQuery
                txtQuery.Text = "";
            }
        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {
        }
    }
}