using TestingApp.Database.Models;
using TestingApp.Main_Menus;

namespace TestingApp.Main_Menus.AddForms.AddConfirmation
{
    public partial class AddConfirmation : Form
    {
        public AddConfirmation()
        {
            InitializeComponent();
        }

        private async void addTestButton_Click(object sender, EventArgs e)
        {
            string testName = nameTestbox.Text;
            string testDesc = descTextbox.Text;

            using (TestingAppContext db = new TestingAppContext())
            {
                var existingTestEntity = db.Tests.FirstOrDefault(x => x.Name == testName);

                if (existingTestEntity == null)
                {
                    Test test = new Test { Name = testName, Description = testDesc };
                    await db.Tests.AddAsync(test);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Test was successfully created!");

                    this.Hide();
                    EditingForm.EditingForm editingForm = new EditingForm.EditingForm(test);
                    editingForm.ShowDialog();
                    return;
                }

                MessageBox.Show("Test with such name already exists!");
                return;
            }
        }
    }
}
