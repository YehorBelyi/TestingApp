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
            this.Close();
            thread = new Thread(openRegisterForm);
            thread.Start();
            thread.Join();
        }
        private void openRegisterForm(object sender)
        {
            Application.Run(new Register());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {

                string userLogin = loginBox.Text.Trim();
                string userPassword = passwordBox.Text;

                using (TestingAppContext db = new TestingAppContext())
                {
                    var existingStudent = db.Students.FirstOrDefault(s => (s.Email.Trim() == userLogin) && (s.Password == userPassword));

                    if (existingStudent != null)
                    {
                        this.Hide();
                        ControlMenu controlMenu = new ControlMenu(existingStudent);
                        controlMenu.ShowDialog();
                        return;
                    }

                    var existingTeacher = db.Teachers.FirstOrDefault(t => (t.Email.Trim() == userLogin) && (t.Password == userPassword));

                    if (existingTeacher != null)
                    {
                        //this.Close();
                        //thread = new Thread(openStudentMenu);
                        //thread.Start();
                        //thread.Join();
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
    }
}