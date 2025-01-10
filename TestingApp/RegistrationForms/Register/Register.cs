using System;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using TestingApp.Database.Models;
using TestingApp.RegistrationForms;
using TestingApp.RegistrationForms.Confirm;

namespace TestingApp
{
    public partial class Register : Form
    {
        string jsonContent = File.ReadAllText("../../../appsettings.json");
        
            
        public SmtpSender? smtp;
        private int? confirmNumber = 0;
        private Random? random = null;

        private readonly string host = null;
        private readonly string port = null;
        private readonly string password = null;
        private string body = null;
        private readonly string subject = "Confirm registration in our testing application";
        private readonly string emailSender = null;

        public Register()
        {
            InitializeComponent();
            JsonNode? jsonNode = JsonNode.Parse(jsonContent);
            host = jsonNode["smtpHost"].ToString();
            password = jsonNode["smtpPassword"].ToString();
            emailSender = jsonNode["emailSender"].ToString();
            port = jsonNode["smtpPort"].ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Checking email and name
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please, enter your email and name.");
                return;
            }

            // Checking passwords
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Boxes for passwords are empty! Fill them first before signing up.");
                return;
            }

            if (textBox3.Text.Length <= 7)
            {
                MessageBox.Show("Your password must have at least 8 symbols!");
                return;
            }

            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (TestingAppContext db = new TestingAppContext())
            {
                string email = textBox1.Text.Trim();
                string studentName = textBox2.Text.ToLower();

                // Checking if there exist any students with similar email
                var existingStudent = db.Students.FirstOrDefault(s =>
                    s.Email.Trim() == email);

                if (existingStudent != null)
                {
                    MessageBox.Show("A student with this email or name already exists!");
                    return;
                }

                // Generate 6-digit confirmation code
                random = new Random();
                confirmNumber = random.Next(100000, 999999);

                body = $"Thanks for signing up into this application! To continue, please, enter this confirmation code in the app: \n{confirmNumber}" +
                        "\nIMPORTANT NOTE: Do not share this code with anyone! Also, this code must be 6-digit.";

                // Send email
                

                MailData maildata = new(this, host, port, emailSender, textBox1.Text.Trim(), subject, body, password, true);
                smtp = new SmtpSender(maildata);
                smtp.SendMessage();

                // Show confirmation dialog
                Confirm confirm = new Confirm(textBox1.Text, (int)confirmNumber);
                var confirmResult = confirm.ShowDialog();

                if (confirmResult == DialogResult.OK)
                {
                    var student = new Student { Email = email, StudentName = studentName, Password = textBox3.Text };

                    db.Students.Add(student);
                    await db.SaveChangesAsync();

                    MessageBox.Show("Registration successful!");
                }
                else
                {
                    MessageBox.Show("Confirmation failed or canceled. Registration aborted.");
                    return;
                }
            }
        }
    }
}


