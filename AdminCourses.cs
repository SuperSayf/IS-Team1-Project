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
    public partial class AdminCourses : Form
    {
        public AdminCourses()
        {
            InitializeComponent();
        }

        private void AdminCourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.courses_avail' table. You can move, or remove it, as needed.
            this.courses_availTableAdapter1.Fill(this.databaseDataSet2.courses_avail);
            // TODO: This line of code loads data into the 'databaseDataSet1.courses_avail' table. You can move, or remove it, as needed.

        }

    }
}
