using TestingApp.Database.Models;

namespace TestingApp.Main_Menus.EditingForm
{
    public partial class EditingForm : Form
    {
        Test test_ = new Test();
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
    }
}
