using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.TestEdit
{
    public partial class TestEdit : Form
    {
        private Test _test;

        private List<Question> loadedQuestions = new List<Question>();
        public TestEdit(Test test)
        {
            InitializeComponent();
            _test = test;
        }

        private async void saveChangesButton_Click(object sender, EventArgs e)
        {
            string newName = testNameTextbox.Text;
            string newDesc = testDescTextbox.Text;

            if ((newName == _test.Name) && (newDesc == _test.Description))
            {
                return;
            }

            _test.Name = newName;
            _test.Description = newDesc;

            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    db.Tests.Update(_test);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Changes were successfully saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while saving entity! Error: {ex.Message}");
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestEdit_Load(object sender, EventArgs e)
        {
            testNameTextbox.Text = _test.Name;
            testDescTextbox.Text = _test.Description;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Id";
            column1.Width = 50;
            column1.ReadOnly = true;
            column1.Name = "testQuestionId";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Question";
            column2.Width = 700;
            column2.ReadOnly = true;
            column2.Name = "testQuestion";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);

            LoadQuestions();
        }

        private async void LoadQuestions()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    var questionsForThisTest = await db.Questions.Where(q => q.TestId == _test.TestId).Include(q => q.Answers).ToListAsync();
                    for (int number = 0; number < questionsForThisTest.Count; ++number)
                    {
                        var quest = questionsForThisTest[number];
                        dataGridView1?.Rows.Add(quest.QuestionId, quest.Text);
                        loadedQuestions.Add(quest);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tests loading error, details: {ex.Message}");
            }
        }

        private void editQuestionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                var questionToEdit = loadedQuestions.FirstOrDefault(q => q.QuestionId == id);
                if (questionToEdit != null)
                {
                    EditingForm.EditingForm editForm = new EditingForm.EditingForm(_test, questionToEdit);
                    editForm.ShowDialog();

                    LoadQuestions();
                }
            }
        }
    }
}
