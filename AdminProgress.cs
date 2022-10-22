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
    
    public partial class AdminProgress : Form
    {
        public AdminProgress()
        {
            InitializeComponent();
            
        }
        String studentNumber;
        String results;
        private void AdminProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.databaseDataSet3.quiz);
        }


        private void myDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             studentNumber = myDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            GetStudentResults();
        }

        private void GetStudentResults()
        {
            //Get selected value first
            resultsTxt.Text = "";
            results = "";

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            Console.Write("Hi?");
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the quiz table student_number is studentNumber a
                OleDbCommand command = new OleDbCommand("SELECT quiz_difficulty, quiz_score, quiz_course FROM quiz WHERE student_num = @studentNumber", connection);
                command.Parameters.AddWithValue("@studentNumber", studentNumber);
                OleDbDataReader reader = command.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {

                    results += count + ": Course: " + reader["quiz_course"].ToString() + ",Quiz Difficulty: " + reader["quiz_difficulty"].ToString() + ",Quiz Score: " + reader["quiz_score"].ToString() + "\n";
                    count++;
                    Console.Write(results);
                }

                resultsTxt.Text = results;
                connection.Close();
            }
        }

    }
}
