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
            usernameInfo.Text = $"Welcome, {student.StudentName}";
        }
    }
}
