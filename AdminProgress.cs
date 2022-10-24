using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_Team1_Project
{
    public partial class AdminProgress : Form
    {
        public AdminProgress()
        {
            InitializeComponent();
        }

        private String studentNumber;
        private String results;

        private void AdminProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.databaseDataSet.students);
        }

        private void myDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentNumber = myDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            GetStudentResults();
        }

        private void GetStudentResults()
        {
            //Get selected value first
            resultsTxt.Text = "";
            results = "";

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + frmLogin.dbPath;
            Console.Write("Hi?");
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.Open();
                // SQL to find where in the quiz table student_number is studentNumber a
                OleDbCommand command = new OleDbCommand("SELECT quiz_difficulty, quiz_score, quiz_course FROM quiz WHERE student_num = @studentNumber", connection);
                command.Parameters.AddWithValue("@studentNumber", studentNumber);
                OleDbDataReader reader = command.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    results += count + ": Course: " + reader["quiz_course"].ToString() + ",Quiz Difficulty: " + reader["quiz_difficulty"].ToString() + ",Quiz Score: " + reader["quiz_score"].ToString() + "\n";
                    count++;
                }

                resultsTxt.Text = results;
                btnPrintReport.Visible = true;
                connection.Close();
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            // Print the results string to a PDF
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //label2.Text = folderDlg.SelectedPath;

                // open the writer
                string fileName = Path.Combine(folderDlg.SelectedPath, studentNumber + ".pdf");
                //FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                Document doc = new Document();

                //Create a New instance of PDFWriter Class for Output File
                PdfWriter.GetInstance(doc, fs);

                //Open the Document
                doc.Open();

                //Add the content of Text File to PDF File
                doc.Add(new Paragraph("Results for Student Number " + studentNumber));
                doc.Add(new Paragraph("Date printed: " + DateTime.Now.ToShortDateString()));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(results));

                //Close the Document
                doc.Close();
                System.Diagnostics.Process.Start(fileName);
            }
        }
    }
}