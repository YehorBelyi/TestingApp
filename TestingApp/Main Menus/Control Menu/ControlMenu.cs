using System.Data.Entity;
using TestingApp.Database.Models;
using TestingApp.Main_Menus.AddForms.AddConfirmation;
using TestingApp.Main_Menus.TestingMenu;

namespace TestingApp.MainMenu
{
    public partial class ControlMenu : Form
    {
        private object _user;

        public ControlMenu()
        {

        }
        public ControlMenu(object user)
        {
            InitializeComponent();
            _user = user;

            if (user is Student student)
            {
                ConfigureForStudent(student);
            }
            else if (user is Teacher teacher)
            {

            }
            else
            {
                MessageBox.Show("Unknown user");
                this.Close();
            }
        }

        private void ConfigureForStudent(Student student)
        {
            //addTestButton.Visible = false;
            usernameInfo.Text = $"Welcome, {student.StudentName}";
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            AddConfirmation addConfirmation = new AddConfirmation();
            addConfirmation.ShowDialog();
            LoadTests();
            //this.Hide();
            //EditingForm editingForm = new EditingForm();
            //editingForm.ShowDialog();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ControlMenu_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "id";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "testId";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Test name";
            column2.Width = 100;
            column2.ReadOnly = true;
            column2.Name = "testName";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Description of the test";
            column3.Width = 200;
            column3.ReadOnly = true;
            column3.Name = "testDesc";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            LoadTests();
        }

        private void LoadTests()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    var availableTests = db.Tests.ToList();
                    for (int number = 0; number < availableTests.Count; ++number)
                    {
                        var test = availableTests[number];
                        dataGridView1?.Rows.Add(test.TestId, test.Name, test.Description);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tests loading error, details: {ex.Message}");
            }
        }

        private async void deleteTestButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this test?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                    using (TestingAppContext db = new TestingAppContext())
                    {
                        var testToDelete = db.Tests
                            .Include(t => t.Questions.Select(q => q.Answers))
                            .FirstOrDefault(t => t.TestId == id);

                        if (testToDelete != null)
                        {
                            foreach (var question in testToDelete.Questions)
                            {
                                db.Answers.RemoveRange(question.Answers);
                            }
                            db.Questions.RemoveRange(testToDelete.Questions);

                            db.Tests.Remove(testToDelete);

                            await db.SaveChangesAsync();

                            MessageBox.Show("Test and all related data were successfully deleted!");
                            LoadTests();
                        }
                        else
                        {
                            MessageBox.Show("Test was not found!");
                            return;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to start this test?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                    using (TestingAppContext db = new TestingAppContext())
                    {
                        var testToStart = db.Tests.Include(t => t.Questions.Select(q => q.Answers)).FirstOrDefault(t => t.TestId == id);
                        this.Hide();
                        TestingMenu testingMenu = new TestingMenu(testToStart);
                        testingMenu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Could not start test!");
                    return;
                }
            }
        }
    }
}
