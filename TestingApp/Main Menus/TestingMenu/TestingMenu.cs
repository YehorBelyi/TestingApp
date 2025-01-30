using System.Data;
using System.Data.Entity;
using System.Text;
using System.Timers;
using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.TestingMenu
{
    public partial class TestingMenu : Form
    {
        private Test _thisTest;
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private Dictionary<int, string> userAnswers = new Dictionary<int, string>();
        private int rightAnswers = 0;

        private System.Timers.Timer _timer;
        private int _elapsedTimeInSeconds = 0;

        private int maxAmountOfQuestions = 0;

        private Student _student;

        public TestingMenu(Test test,Student student)
        {
            InitializeComponent();
            _thisTest = test;
            _student = student;
            questions = new List<Question>();

            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += Timer_Elapsed;

            LoadQuestions();
        }
        private void TestingMenu_Load(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                DisplayCurrentQuestion();
                _timer.Start();
                questionsLeftLabel.Text = $"{currentQuestionIndex+1}/{maxAmountOfQuestions}";
            }
            else
            {
                MessageBox.Show("No questions available for this test!");
                _timer.Stop();
                this.Close();
                return;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _elapsedTimeInSeconds++;

            TimeSpan timeSpan = TimeSpan.FromSeconds(_elapsedTimeInSeconds);

            if (this.timerLabel.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.timerLabel.Text = timeSpan.ToString(@"mm\:ss");
                }));
            }
            else
            {
                this.timerLabel.Text = timeSpan.ToString(@"mm\:ss");
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

            LoadAnswers(currentQuestion.QuestionId);
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count - 1)
            {
                var currentQuestion = questions[currentQuestionIndex];
                var selectedAnswerText = userAnswers.ContainsKey(currentQuestion.QuestionId)
                                            ? userAnswers[currentQuestion.QuestionId]
                                            : null;

                if (selectedAnswerText != null)
                {
                    using (TestingAppContext db = new TestingAppContext())
                    {
                        var correctAnswer = db.Answers.FirstOrDefault(a => a.QuestionId == currentQuestion.QuestionId && a.IsCorrect);

                        if (correctAnswer != null)
                        {
                            if (selectedAnswerText == correctAnswer.Text)
                            {
                                MessageBox.Show("Your answer is correct!");
                                ++rightAnswers; 
                            }
                            else
                            {
                                MessageBox.Show("Your answer is incorrect!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No correct answer found in the database.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an answer!");
                    return; 
                }

                ++currentQuestionIndex;
                questionsLeftLabel.Text = $"{currentQuestionIndex + 1}/{maxAmountOfQuestions}";
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
                    maxAmountOfQuestions = questions.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading questions for this test. Details: {ex.Message}");
                return;
            }
        }

        private void LoadAnswers(int questionId)
        {
            try
            {
                using (TestingAppContext db = new TestingAppContext())
                {
                    var currentAnswers = db.Answers.Where(a => a.QuestionId == questionId);

                    if (currentAnswers != null)
                    {
                        listBox1.Items.Clear();
                        foreach (var answer in currentAnswers)
                        {
                            listBox1.Items.Add(answer.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading answers for this question. Details: {ex.Message}");
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnswerText = listBox1.SelectedItem.ToString();
                userAnswers[questions[currentQuestionIndex].QuestionId] = selectedAnswerText;
            }
        }

        private async void finishButton_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count - 1)
            {
                MessageBox.Show("You haven't finished doing your test yet!");
                return;
            }
            else
            {
                _timer.Stop();

                double sumMark = (double)rightAnswers / questions.Count * 12;
                MessageBox.Show($"Your score is: {sumMark:F2}");

                using (TestingAppContext db = new TestingAppContext())
                {
                    var existingTestResult = db.TestResults
                        .Any(r => r.TestId == _thisTest.TestId && r.StudentId == _student.Id);

                    if (existingTestResult)
                    {
                        MessageBox.Show("You have already completed this test.");
                        return;
                    }
                    else
                    {
                        var testResult = new TestResult
                        {
                            TestId = _thisTest.TestId,
                            StudentId = _student.Id,
                            Score = (decimal)sumMark,
                            DateTaken = DateTime.Now,
                            TimeSpent = _elapsedTimeInSeconds
                        };

                        db.TestResults.Add(testResult);
                        await db.SaveChangesAsync();
                        this.Close();
                        return;
                    }
                }
            }
        }

    }
}
