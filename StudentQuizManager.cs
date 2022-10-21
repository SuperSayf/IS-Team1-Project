using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}