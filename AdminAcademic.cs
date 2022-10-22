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
    public partial class AdminAcademic : Form
    {
        public AdminAcademic()
        {
            InitializeComponent();
        }

        private void academicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet3);

        }

        private void academic_numTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAcademic_Load(object sender, EventArgs e)
        {
            this.academicTableAdapter.Fill(this.databaseDataSet3.academic);
        }
    }
}
