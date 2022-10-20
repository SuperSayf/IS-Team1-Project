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
    public partial class StudentQuizView : Form
    {
        public StudentQuizView()
        {
            InitializeComponent();
        }

        private void StudentQuizView_Load(object sender, EventArgs e)
        {
            lblCourseName.Text = StudentCourses.selectedCourse;
            lblDifficulty.Text = "Level: " + StudentQuizManager.quizDifficulty;
        }
    }
}