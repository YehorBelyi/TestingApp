using TestingApp.Database.Models;
using TestingApp.Main_Menus.AddForms.AddConfirmation;

namespace TestingApp.MainMenu
{
    public partial class ControlMenu : Form
    {
        private object _user;
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
            //this.Hide();
            //EditingForm editingForm = new EditingForm();
            //editingForm.ShowDialog();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
