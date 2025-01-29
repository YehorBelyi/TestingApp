namespace TestingApp.Main_Menus.TestingMenu
{
    partial class TestingMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            finishButton = new Button();
            nextQuestionButton = new Button();
            label1 = new Label();
            answersBox = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // questionBox
            // 
            questionBox.Location = new Point(12, 99);
            questionBox.Name = "questionBox";
            questionBox.ReadOnly = true;
            questionBox.Size = new Size(509, 171);
            questionBox.TabIndex = 0;
            questionBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(527, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 241);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // finishButton
            // 
            finishButton.Location = new Point(527, 482);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(401, 43);
            finishButton.TabIndex = 2;
            finishButton.Text = "Finish test";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new Point(527, 419);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(401, 43);
            nextQuestionButton.TabIndex = 3;
            nextQuestionButton.Text = "Next question";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += nextQuestionButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(200, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 5;
            label1.Text = "Questions";
            // 
            // answersBox
            // 
            answersBox.AutoSize = true;
            answersBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            answersBox.Location = new Point(210, 288);
            answersBox.Name = "answersBox";
            answersBox.Size = new Size(101, 32);
            answersBox.TabIndex = 6;
            answersBox.Text = "Answers";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 326);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(509, 199);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // TestingMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 547);
            Controls.Add(listBox1);
            Controls.Add(answersBox);
            Controls.Add(label1);
            Controls.Add(nextQuestionButton);
            Controls.Add(finishButton);
            Controls.Add(pictureBox1);
            Controls.Add(questionBox);
            Name = "TestingMenu";
            Text = "TestingMenu";
            Load += TestingMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox questionBox;
        private PictureBox pictureBox1;
        private Button finishButton;
        private Button nextQuestionButton;
        private Label label1;
        private Label answersBox;
        private ListBox listBox1;
    }
}