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
    public partial class AdminCourses : Form
    {
        private string sSelected; 
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

        public void refreshGrid()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from courses_avail", conn);
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
            txtModule.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLecturerEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLecturerNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sSelected = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM courses_avail WHERE lecturer_number = @selected", connection);
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
                refreshGrid();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO courses_avail (module, lecturer_email, lecturer_number) VALUES (@module, @lecturer_email, @lecturer_number)", connection);
                command.Parameters.AddWithValue("@module", txtModule.Text);
                command.Parameters.AddWithValue("@lecturer_email", txtLecturerEmail.Text);
                command.Parameters.AddWithValue("@lecturer_number", txtLecturerNumber.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Module successfully added");
                refreshGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ frmLogin.dbPath);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE courses_avail SET module = @module, lecturer_email = @lecturer_email, lecturer_number = @lecturer_number WHERE lecturer_number = @selected", conn);
            cmd.Parameters.AddWithValue("@module", txtModule.Text);
            cmd.Parameters.AddWithValue("@lecturer_email", txtLecturerEmail.Text);
            cmd.Parameters.AddWithValue("@lecturer_number", txtLecturerNumber.Text);
            cmd.Parameters.AddWithValue("@selected", sSelected);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshGrid();
            MessageBox.Show("1 record updated");
        }
    }
}
