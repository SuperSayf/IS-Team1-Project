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
    public partial class AdminAcademic : Form
    {
        private string sSelected;

        public AdminAcademic()
        {
            InitializeComponent();
        }

        private void academicBindingSource3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource3.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseDataSet4);

        }

        private void AdminAcademic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet4.academic' table. You can move, or remove it, as needed.
            this.academicTableAdapter1.Fill(this.databaseDataSet4.academic);

        }
        public void refreshGrid()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from academic", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtacanum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtacaemail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtacaname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtacasur.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtacacourse.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtacapass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            sSelected = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void academicBindingSource4BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.academicBindingSource4.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.databaseDataSet41);

        }

        private void AdminAcademic_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet41.academic' table. You can move, or remove it, as needed.
            this.academicTableAdapter2.Fill(this.databaseDataSet41.academic);

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
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_newCellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNewNum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNewEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNewName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNewSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNewCourse.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNewPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            sSelected = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnnewDelete_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM academic WHERE academic_number = @selected", connection);
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

        private void btnnewAdd_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
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

        private void btnnewUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE academic SET [academic_num] = @academic_num, [academic_email] = @academic_email, [academic_name] = @academic_name, [academic_surname] = @academic_surname,[academic_course] = @academic_course,[academic_course] = @academic_course, [academic_password]=@academic_password WHERE [academic_num] = @selected", conn);
            cmd.Parameters.AddWithValue("@academic_num", txtNewNum.Text);
            cmd.Parameters.AddWithValue("@academic_email", txtNewEmail.Text);
            cmd.Parameters.AddWithValue("@academic_name", txtNewName.Text);
            cmd.Parameters.AddWithValue("@academic_surname", txtNewSurname.Text);
            cmd.Parameters.AddWithValue("@academic_course", txtNewCourse.Text);
            cmd.Parameters.AddWithValue("@academic_password", txtNewPass.Text);
            cmd.Parameters.AddWithValue("@selected", sSelected);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshGrid();
            MessageBox.Show("1 record updated");
        }

        private void btnnewClear_Click(object sender, EventArgs e)
        {
            txtNewNum.Clear();
            txtNewEmail.Clear();
            txtNewName.Clear();
            txtNewSurname.Clear();
            txtNewCourse.Clear();
            txtNewPass.Clear();
           
        }
    }
}

// the academicnumbertxt name is txtNewNum
//the academicemail textbox name is txtNewEmail
//the name textbix is txtNewName
//the surname textbx is txtNewSurname
//the Course textbix us txtNewCourse
//the password " is txtNewPass
//update btn name is btnnewUpdate
//add btn name is btnnewAdd
//delete btn name is btnnewDelete
//clar btn name is btnnewClear
// u can add the adacemic database and it will work