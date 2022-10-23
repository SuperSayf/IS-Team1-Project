using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Team1_Project
{
    public partial class PrathamFlopIS : Form
    {
        private string sSelected;
        public PrathamFlopIS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void academicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet4);

        }

        private void PrathamFlopIS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet4.academic' table. You can move, or remove it, as needed.
            this.academicTableAdapter.Fill(this.databaseDataSet4.academic);

        }
        public void refreshnewGrid()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from academic", conn);
                da.Fill(dt);
                academicDataGridView.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Connection:" + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool ValidInput()
        {
            if (txtNewNum.Text == String.Empty)
            {
                return false;
            }
            else if (txtNewEmail.Text == String.Empty)
            {
                return false;
            }
            else if (txtNewName.Text == String.Empty)
            {
                return false;
            }
            else if (txtNewSurname.Text == String.Empty)
            {
                return false;
            }
            else if (txtNewCourse.Text == String.Empty)
            {
                return false;
            }
            else if (txtNewPass.Text == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnnewDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnnewAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnewUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnnewClear_Click(object sender, EventArgs e)
        {
            

        }

        private void btnnewAdd_Click_1(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            Boolean valid = ValidInput();
            if (valid == true)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO academic ([academic_num], [academic_email], [academic_name], [academic_surname], [academic_course], [academic_password]) VALUES (@academic_num, @academic_email, @academic_name, @academic_surname, @academic_course, @academic_password)", connection);
                    command.Parameters.AddWithValue("@academic_num", txtNewNum.Text);
                    command.Parameters.AddWithValue("@academic_email", txtNewEmail.Text);
                    command.Parameters.AddWithValue("@academic_name", txtNewName.Text);
                    command.Parameters.AddWithValue("@academic_surname", txtNewSurname.Text);
                    command.Parameters.AddWithValue("@academic_course", txtNewCourse.Text);
                    command.Parameters.AddWithValue("@academic_password", txtNewPass.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Module successfully added");
                    refreshnewGrid();
                }
            }
            else
            {
                MessageBox.Show("Do not leave any textboxes empty");
            }
            
        }

        private void btnnewDelete_Click_1(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM academic WHERE academic_num = @selected", connection);
                cmd.Parameters.AddWithValue("@selected", sSelected);
                DialogResult ans = MessageBox.Show("Delete this record?", "Confirmation",
                MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("1 record deleted");
                }
                else
                {
                    MessageBox.Show("No record was deleted.");
                }
                connection.Close();
                refreshnewGrid();

            }
        }

        private void btnnewUpdate_Click_1(object sender, EventArgs e)
        {
            if (sSelected == txtNewNum.Text)
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE academic SET  [academic_email] = @academic_email, [academic_name] = @academic_name, [academic_surname] = @academic_surname,[academic_course] = @academic_course, [academic_password]=@academic_password WHERE [academic_num] = @selected", conn);
                //cmd.Parameters.AddWithValue("@academic_num", txtNewNum.Text);
                cmd.Parameters.AddWithValue("@academic_email", txtNewEmail.Text);
                cmd.Parameters.AddWithValue("@academic_name", txtNewName.Text);
                cmd.Parameters.AddWithValue("@academic_surname", txtNewSurname.Text);
                cmd.Parameters.AddWithValue("@academic_course", txtNewCourse.Text);
                cmd.Parameters.AddWithValue("@academic_password", txtNewPass.Text);
                cmd.Parameters.AddWithValue("@selected", sSelected);
                cmd.ExecuteNonQuery();
                conn.Close();
                refreshnewGrid();
                MessageBox.Show("1 record updated");
            }
            else
            {
                MessageBox.Show("You may not change the Primary Key");
            }
        }

        private void btnnewClear_Click_1(object sender, EventArgs e)
        {
            txtNewNum.Clear();
            txtNewEmail.Clear();
            txtNewName.Clear();
            txtNewSurname.Clear();
            txtNewCourse.Clear();
            txtNewPass.Clear();
        }

        private void academicDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void academicDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNewNum.Text = academicDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNewEmail.Text = academicDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNewName.Text = academicDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNewSurname.Text = academicDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNewCourse.Text = academicDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNewPass.Text = academicDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            sSelected = academicDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
