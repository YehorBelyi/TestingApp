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

            // Determine the selected user type
            string userType = radioButton1.Checked ? "Teacher" : (radioButton2.Checked ? "Student" : null);

            if (userType == null)
            {
                MessageBox.Show("Please select a user type (Student or Teacher).");
                return;
            }

            using (TestingAppContext db = new TestingAppContext())
            {
                string email = textBox1.Text.Trim();
                string userName = textBox2.Text.ToLower();

                var existingStudent = db.Students.FirstOrDefault(s => s.Email.Trim() == email);

                var existingTeacher = db.Teachers.FirstOrDefault(t => t.Email.Trim() == email);

                if (existingStudent != null || existingTeacher != null)
                {
                    MessageBox.Show("A user with this email already exists!");
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
                    if (userType == "Student")
                    {
                        var student = new Student { Email = email, StudentName = userName, Password = textBox3.Text };
                        await db.Students.AddAsync(student);
                    }
                    else if (userType == "Teacher")
                    {
                        var teacher = new Teacher { Email = email, TeacherName = userName, Password = textBox3.Text };
                        await db.Teachers.AddAsync(teacher);
                    }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Additional logic for when the "Student" radio button is selected
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Additional logic for when the "Teacher" radio button is selected
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}