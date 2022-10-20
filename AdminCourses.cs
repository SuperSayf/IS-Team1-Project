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
            // TODO: This line of code loads data into the 'databaseDataSet1.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.databaseDataSet1.admin);
            // TODO: This line of code loads data into the 'databaseDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.databaseDataSet1.students);
            // TODO: This line of code loads data into the 'databaseDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.databaseDataSet.students);
            // TODO: This line of code loads data into the 'databaseDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.databaseDataSet.courses);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillBy(this.databaseDataSet.students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillBy1(this.databaseDataSet.students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
