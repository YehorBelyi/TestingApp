using Microsoft.EntityFrameworkCore;
using TestingApp.Database.Models;
using TestingApp.Exceptions;
using TestingApp.MainMenu;

namespace TestingApp.RegistrationForms.Login
{
    public partial class Login : Form
    {
        Thread thread;

        public Login()
        {
            InitializeComponent();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userLogin = loginBox.Text.Trim();
                string userPassword = passwordBox.Text;

                using (TestingAppContext db = new TestingAppContext())
                {
                    var existingStudent = await db.Students.FirstOrDefaultAsync(s => (s.Email.Trim() == userLogin) && (s.Password == userPassword));

                    if (existingStudent != null)
                    {
                        this.Hide();
                        ControlMenu controlMenu = new ControlMenu(existingStudent);
                        controlMenu.ShowDialog();
                        return;
                    }

                    var existingTeacher = await db.Teachers.FirstOrDefaultAsync(t => (t.Email.Trim() == userLogin) && (t.Password == userPassword));

                    if (existingTeacher != null)
                    {
                        this.Hide();
                        ControlMenu controlMenu = new ControlMenu(existingTeacher);
                        controlMenu.ShowDialog();
                        return;
                    }

                    MessageBox.Show("Wrong login or password!");
                    return;
                }
            }
            catch (AppException ex)
            {
                MessageBox.Show($"Error: {ex.Message} | Code: {ex.ErrorCode}");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Default error: {ex.Message}");
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}