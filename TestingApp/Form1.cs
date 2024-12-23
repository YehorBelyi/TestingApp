using System;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник події для кнопки реєстрації
        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка на збіг паролів
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я та підтвердження паролю.");
                return;
            }

            if (textBox2.Text == textBox4.Text)
            {
                MessageBox.Show("Реєстрація успішна!");
            }
            else
            {
                MessageBox.Show("Паролі не співпадають!");
            }
        }
    }
}


