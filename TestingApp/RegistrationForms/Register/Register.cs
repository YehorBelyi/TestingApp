using System;
using System.Windows.Forms;
using TestingApp.RegistrationForms;
using TestingApp.RegistrationForms.Confirm;

namespace TestingApp
{
    public partial class Register : Form
    {
        public SmtpSender? smtp;
        private int? confirmNumber = 0;
        private Random? random = null;

        private string host = "smtp.gmail.com";
        private string port = "587";
        private string password = "wwhw zqut cnun naqw";
        private string body = null;
        private string subject = "Confirm registration in our testing application";
        private string emailSender = "rexetorchik@gmail.com";

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checking passwords
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please, enter your email and name.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Password do not match!");
                    return;
                }

                // Generating 6-digit random code for confirming user registration
                random = new Random();
                confirmNumber = random.Next(100000, 999999);

                body = $"Thanks for signing up into this application! To continue, please, enter this confirmation code in the app: \n{confirmNumber}" + "\nIMPORTANT NOTE: Do not share this code to anyone! Also, this code must be 6-digit.";


                MailData maildata = new(this, host, port,
                emailSender, textBox1.Text.Trim(),
                subject, body,
                password, true);

                smtp = new SmtpSender(maildata);
                smtp.SendMessage();

                Confirm confirm = new Confirm(textBox1.Text, confirmNumber);
                confirm.ShowDialog();
            }
            else if (textBox3.Text.Length <= 7) {
                MessageBox.Show("Your password must have at least 8 symbols!");
                return;
            }
            else
            {
                MessageBox.Show("Boxes for passwords are empty! Fill them first before signing up.");
                return;
            }

        }
    }
}


