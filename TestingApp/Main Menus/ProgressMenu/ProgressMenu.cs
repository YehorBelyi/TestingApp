using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingApp.Database.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace TestingApp.Main_Menus.ProgressMenu
{
    public partial class ProgressMenu : Form
    {
        private Student _student;
        public ProgressMenu(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "testName";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "Test name";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Your final mark";
            column2.Width = 100;
            column2.ReadOnly = true;
            column2.Name = "testMark";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);

            LoadStudentResults();
        }

        private void LoadStudentResults()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    var studentResults = db.TestResults
                        .Where(tr => tr.StudentId == _student.Id)
                        .Select(tr => new
                        {
                            TestName = tr.Test.Name,
                            TestScore = tr.Score
                        })
                        .ToList();

                    if (!studentResults.Any())
                    {
                        MessageBox.Show("No results found for this student.");
                        return;
                    }

                    foreach (var result in studentResults)
                    {
                        dataGridView1.Rows.Add(result.TestName, result.TestScore);
                    }

                    decimal averageMark = studentResults.Average(t => t.TestScore);
                    averageMarkTextBox.Text = averageMark.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading test results: {ex.Message}");
            }
        }

        private void averageMarkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
