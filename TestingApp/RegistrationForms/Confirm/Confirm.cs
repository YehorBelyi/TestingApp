using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp.RegistrationForms.Confirm
{
    public partial class Confirm : Form
    {
        static SmtpClient? confirmClient;
        private int? confirmNumber = 0;
        public Confirm()
        {
            InitializeComponent();
        }

        public Confirm(string email, int? confirmNumber)
        {
            InitializeComponent();
            emailRow.Text = $"To continue, please enter code, that will be sent\nto this email: {email}";
            this.confirmNumber = confirmNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(confirmBox.Text, out int userCode))
            {
                if (userCode == confirmNumber)
                {
                    MessageBox.Show("Registration is done! Thank you!");
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong confirmation code! Try again.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!");
                return;
            }
        }
    }
}
