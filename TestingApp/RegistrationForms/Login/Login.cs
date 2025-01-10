using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingApp.Database.Models;
using TestingApp.Exceptions;

namespace TestingApp.RegistrationForms.Login
{
    public partial class Login : Form
    {
        Thread thread;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                        // Main menu enter
                        MessageBox.Show("Successfully logged in");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong login or password!");
                        return;
                    }
                }
            } catch (AppException ex)
            {
                MessageBox.Show($"Error: {ex.Message} | Code: {ex.ErrorCode}");
                return;
            } catch (Exception ex)
            {
                MessageBox.Show($"Default error: {ex.Message}");
                return;
            }
        }
    }
}
