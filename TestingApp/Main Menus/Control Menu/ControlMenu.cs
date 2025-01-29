using System.Data.Entity;
using TestingApp.Database.Models;
using TestingApp.Main_Menus.AddForms.AddConfirmation;

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
            column1.HeaderText = "N";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "testNumber";
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
                        dataGridView1?.Rows.Add(number + 1, test.Name, test.Description);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tests loading error, details: {ex.Message}");
            }
        }

    }
}
