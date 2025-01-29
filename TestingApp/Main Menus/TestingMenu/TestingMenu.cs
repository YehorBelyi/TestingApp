using System.Data;
using System.Data.Entity;
using System.Text;
using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.TestingMenu
{
    public partial class TestingMenu : Form
    {
        private Test _thisTest;
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private Dictionary<int, string> userAnswers = new Dictionary<int, string>();

        public TestingMenu(Test test)
        {
            InitializeComponent();
            _thisTest = test;
            questions = new List<Question>();
            LoadQuestions();
        }
        private void TestingMenu_Load(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show("No questions available for this test!");
                return;
            }
        }
        private void DisplayCurrentQuestion()
        {
            var currentQuestion = questions[currentQuestionIndex];
            questionBox.Text = currentQuestion.Text;

            if (currentQuestion.Image != null && currentQuestion.Image.Length > 0)
            {
                using (var ms = new MemoryStream(currentQuestion.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true; 
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
            }

            listBox1.Items.Clear();
            foreach (var answer in currentQuestion.Answers)
            {
                listBox1.Items.Add(answer.Text);
            }
        }


        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show("You have reached the end of the test!");
                return;
            }
        }
        private void LoadQuestions()
        {
            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    questions = db.Questions.Where(q => q.TestId == _thisTest.TestId).Include(q => q.Answers).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading questions for this test. Details: {ex.Message}");
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                userAnswers[questions[currentQuestionIndex].QuestionId] = listBox1.SelectedItem.ToString();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            StringBuilder resultSummary = new StringBuilder();
            foreach (var answer in userAnswers)
            {
                var question = questions.First(q => q.QuestionId == answer.Key);
                resultSummary.AppendLine($"Question: {question.Text}");
                resultSummary.AppendLine($"Your Answer: {answer.Value}");
                resultSummary.AppendLine();
            }

            MessageBox.Show(resultSummary.ToString(), "Test Results");
        }
    }
}
