using System;
using System.Collections;
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
    public partial class StudentQuizView : Form
    {
        // Array to store the questions
        private static ArrayList questions = new ArrayList();

        private static ArrayList answers = new ArrayList();

        private static ArrayList studentAnswers = new ArrayList();

        private static int score = 0;

        private static int currQuestion = 0;

        public StudentQuizView()
        {
            InitializeComponent();
        }

        private void StudentQuizView_Load(object sender, EventArgs e)
        {
            questions.Clear();
            answers.Clear();
            studentAnswers.Clear();
            score = 0;
            currQuestion = 0;

            lblCourseName.Text = StudentCourses.selectedCourse;
            lblDifficulty.Text = "Level: " + StudentQuizManager.quizDifficulty;

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the quizbank table quizbank_course is selectedCourse and where quiz_difficulty is quizDifficulty
                OleDbCommand command = new OleDbCommand("SELECT * FROM quizbank WHERE quizbank_course = @quizbank_course AND quiz_difficulty = @quiz_difficulty", connection);
                command.Parameters.AddWithValue("@quizbank_course", StudentCourses.selectedCourse);
                command.Parameters.AddWithValue("@quiz_difficulty", StudentQuizManager.quizDifficulty);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the questions to the array
                    questions.Add(reader["quizbank_question"].ToString());
                    answers.Add(reader["quizbank_answer"].ToString());
                }

                connection.Close();
            }

            // Randomize the ArrayList
            RandomizeList(questions, answers);

            // Set the text of the labels to the first question
            lblQuestion.Text = questions[0].ToString();

            lblQuestNum.Text = (currQuestion + 1).ToString() + "/" + questions.Count.ToString();

            btnPrev.Enabled = false;
        }

        public static void RandomizeList(ArrayList questions, ArrayList answers)
        {
            Random r = new Random();
            for (int i = questions.Count - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);
                object temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;

                object temp2 = answers[i];
                answers[i] = answers[j];
                answers[j] = temp2;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;

            currQuestion++;
            // Set the question
            lblQuestion.Text = questions[currQuestion].ToString();
            lblQuestNum.Text = (currQuestion + 1).ToString() + "/" + questions.Count.ToString();

            // Check if studentAnswers[currQuestion] throws an error

            if (currQuestion <= studentAnswers.Count - 1)
            {
                txtAnswer.Text = studentAnswers[currQuestion].ToString();

                // If the answer is different to the student answer, then update the student answer
                //if (txtAnswer.Text != studentAnswers[currQuestion].ToString())
                //{
                //    studentAnswers[currQuestion] = txtAnswer.Text;
                //}
            }
            else
            {
                studentAnswers.Add(txtAnswer.Text);
                txtAnswer.Clear();
            }

            // If it is the last question, disable the next button, and enable the submit button
            if (currQuestion == questions.Count - 1)
            {
                btnNext.Visible = false;
                btnSubmit.Visible = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Set the question
            currQuestion--;

            if (currQuestion < questions.Count - 1)
            {
                btnNext.Visible = true;
            }

            if (currQuestion <= studentAnswers.Count - 1)
            {
                txtAnswer.Text = studentAnswers[currQuestion].ToString();

                // If the answer is different to the student answer, then update the student answer
                //if (txtAnswer.Text != studentAnswers[currQuestion].ToString())
                //{
                //    studentAnswers[currQuestion] = txtAnswer.Text;
                //}
            }
            else
            {
                studentAnswers.Add(txtAnswer.Text);
                txtAnswer.Text = studentAnswers[studentAnswers.Count - 2].ToString();
            }

            lblQuestion.Text = questions[currQuestion].ToString();
            lblQuestNum.Text = (currQuestion + 1).ToString() + "/" + questions.Count.ToString();

            // If the answer is different to the student answer, then update the student answer
            //if (txtAnswer.Text != studentAnswers[currQuestion].ToString())
            //{
            //    studentAnswers[currQuestion] = txtAnswer.Text;
            //}

            // If it is the first question, disable the previous button
            if (currQuestion == 0)
            {
                btnPrev.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Compare the studentAnswers array and the answers array
            for (int i = 0; i < studentAnswers.Count; i++)
            {
                if (studentAnswers[i].ToString() == answers[i].ToString())
                {
                    score++;
                }
            }

            bool isPassed = false;

            if (score >= 5)
            {
                isPassed = true;
            }

            // Display the score
            MessageBox.Show("You scored " + score + "/" + questions.Count + "!", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to insert into the quiz table the student's number, quiz_difficulty, quiz_score, and quiz_pass
                OleDbCommand command = new OleDbCommand("INSERT INTO quiz (student_num, quiz_course, quiz_difficulty, quiz_pass, quiz_score) VALUES (@student_num, @quiz_course, @quiz_difficulty, @quiz_pass, @quiz_score)", connection);
                command.Parameters.AddWithValue("@student_num", frmLogin.StudentNum);
                command.Parameters.AddWithValue("@quiz_course", StudentCourses.selectedCourse);
                command.Parameters.AddWithValue("@quiz_difficulty", StudentQuizManager.quizDifficulty);
                command.Parameters.AddWithValue("@quiz_pass", isPassed);
                command.Parameters.AddWithValue("@quiz_score", score);
                command.ExecuteNonQuery();
                connection.Close();
            }

            StudentMain.loadform(new StudentQuizManager());
        }
    }
}