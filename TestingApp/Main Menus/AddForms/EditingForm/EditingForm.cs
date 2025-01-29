using System.Data.Entity;
using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.EditingForm
{
    public partial class EditingForm : Form
    {
        private Test test_;
        private Question selectedQuestion;
        private List<Answer> answerList = new List<Answer>();
        private static byte[] thisImage = null;

        public EditingForm(Test test)
        {
            InitializeComponent();
            test_ = test;
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addAnswerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answerTextbox.Text))
            {
                MessageBox.Show("Answer cannot be empty!");
                return;
            }

            Answer newAnswer = new Answer { Text = answerTextbox.Text, IsCorrect = ifRightChekbox.Checked };
            answerList.Add(newAnswer);

            answersListbox.Items.Add(newAnswer.Text + (newAnswer.IsCorrect ? " (Correct)" : ""));

            answerTextbox.Clear();
            ifRightChekbox.Checked = false;
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filename);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            thisImage = File.ReadAllBytes(filename);
        }

        private async void nextQuestionButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(questionTextbox.Text))
            {
                MessageBox.Show("Your question cannot be empty!");
                return;
            }


            if (answerList.Count <= 1)
            {
                MessageBox.Show("Your question must have at least 2 answers!");
                return;
            }
            try
            {
                if (weightNumber.Value < 0)
                {
                    MessageBox.Show("Weight of question cannot be lower than 1!");
                    return;
                }

                using (TestingAppContext db = new TestingAppContext())
                {
                    Question newQuestion = new Question { Text = questionTextbox.Text, Image = thisImage, Answers = answerList.ToList(), Weight = (int)weightNumber.Value, TestId = test_.TestId };
                    await db.Questions.AddAsync(newQuestion);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Question was sucessfully created!");
                }

                pictureBox1.Image = null;
                thisImage = null;
                questionTextbox.Clear();
                weightNumber.Value = 0;
                answerList.Clear();
                answersListbox.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }


        }

        private void saveTestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test was successfully saved!");
            this.Close();
        }

        private void deletePictureButton_Click(object sender, EventArgs e)
        {
            if (thisImage != null)
            {
                thisImage = null;
                pictureBox1.Image = null;
                return;
            }
        }
    }
}
