using Microsoft.EntityFrameworkCore;
using System.Linq;
using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.EditingForm
{
    public partial class EditingForm : Form
    {
        private Test test_;
        private Question selectedQuestion;
        private List<Answer> answerList = new List<Answer>();
        private static byte[] thisImage = null;

        private Question questionToEdit;

        public EditingForm(Test test, Question question)
        {
            InitializeComponent();
            questionToEdit = question;
            test_ = test;
            loadQuestionToEdit();
            saveChangesButton.Enabled = true;
            saveChangesButton.Visible = true;
            nextQuestionButton.Enabled = false;
            nextQuestionButton.Visible = false;
            saveTestButton.Enabled = false;
            saveTestButton.Visible = false;
        }

        public EditingForm(Test test)
        {
            InitializeComponent();
            test_ = test;
            saveChangesButton.Enabled = false;
            saveChangesButton.Visible = false;
            nextQuestionButton.Enabled = true;
            nextQuestionButton.Visible = true;
            saveTestButton.Enabled = true;
            saveTestButton.Visible = true;
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
            thisImage = null;
            pictureBox1.Image = null;
            return;
        }

        private void loadQuestionToEdit()
        {
            questionTextbox.Text = questionToEdit.Text;
            if (questionToEdit.Image != null)
            {
                using (var ms = new MemoryStream(questionToEdit.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void saveChangesButton_Click(object sender, EventArgs e)
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
                    var questionToUpdate = await db.Questions
                                                   .Include(q => q.Answers)
                                                   .FirstOrDefaultAsync(q => q.QuestionId == questionToEdit.QuestionId);

                    if (questionToUpdate == null)
                    {
                        MessageBox.Show("Question not found in the database!");
                        return;
                    }

                    questionToUpdate.Text = questionTextbox.Text;
                    questionToUpdate.Image = thisImage;
                    questionToUpdate.Weight = (int)weightNumber.Value;

                    db.Answers.RemoveRange(questionToUpdate.Answers);

                    foreach (var answer in answerList)
                    {
                        answer.QuestionId = questionToUpdate.QuestionId; 
                        db.Answers.Add(answer);
                    }

                    await db.SaveChangesAsync();
                    MessageBox.Show("Question was successfully edited!");
                }

                pictureBox1.Image = null;
                thisImage = null;
                questionTextbox.Clear();
                weightNumber.Value = 0;
                answerList.Clear();
                answersListbox.Items.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
