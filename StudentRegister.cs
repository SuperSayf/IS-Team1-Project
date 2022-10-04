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
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Open the StudentMain form and close this one
            StudentMain studentMain = new StudentMain();
            studentMain.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentNo.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
