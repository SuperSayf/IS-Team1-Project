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
    public partial class AdminProgress : Form
    {
        public AdminProgress()
        {
            InitializeComponent();
        }

        private void AdminProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.databaseDataSet3.quiz);

        }
    }
}
