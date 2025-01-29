namespace TestingApp.Main_Menus.EditingForm
{
    partial class EditingForm
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
            pictureBox1 = new PictureBox();
            weightNumber = new NumericUpDown();
            label1 = new Label();
            questionTextbox = new RichTextBox();
            label2 = new Label();
            addPictureButton = new Button();
            label3 = new Label();
            label4 = new Label();
            addAnswerButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            answersListbox = new ListBox();
            ifRightChekbox = new CheckBox();
            answerTextbox = new RichTextBox();
            label5 = new Label();
            saveTestButton = new Button();
            nextQuestionButton = new Button();
            deletePictureButton = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightNumber).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(453, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 201);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // weightNumber
            // 
            weightNumber.Location = new Point(119, 445);
            weightNumber.Name = "weightNumber";
            weightNumber.Size = new Size(134, 23);
            weightNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 427);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 5;
            label1.Text = "Weight for this question";
            // 
            // questionTextbox
            // 
            questionTextbox.Location = new Point(16, 52);
            questionTextbox.Name = "questionTextbox";
            questionTextbox.Size = new Size(341, 161);
            questionTextbox.TabIndex = 6;
            questionTextbox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(65, 13);
            label2.Name = "label2";
            label2.Size = new Size(241, 30);
            label2.TabIndex = 7;
            label2.Text = "Enter your question here";
            // 
            // addPictureButton
            // 
            addPictureButton.Location = new Point(453, 249);
            addPictureButton.Name = "addPictureButton";
            addPictureButton.Size = new Size(155, 23);
            addPictureButton.TabIndex = 8;
            addPictureButton.Text = "Choose picture";
            addPictureButton.UseVisualStyleBackColor = true;
            addPictureButton.Click += addPictureButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 216);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 9;
            label3.Text = "You can attach a picture to the question";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(588, 231);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "<optional>";
            // 
            // addAnswerButton
            // 
            addAnswerButton.Location = new Point(131, 369);
            addAnswerButton.Name = "addAnswerButton";
            addAnswerButton.Size = new Size(112, 23);
            addAnswerButton.TabIndex = 11;
            addAnswerButton.Text = "Add answer";
            addAnswerButton.UseVisualStyleBackColor = true;
            addAnswerButton.Click += addAnswerButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // answersListbox
            // 
            answersListbox.FormattingEnabled = true;
            answersListbox.ItemHeight = 15;
            answersListbox.Location = new Point(453, 336);
            answersListbox.Name = "answersListbox";
            answersListbox.Size = new Size(317, 94);
            answersListbox.TabIndex = 12;
            // 
            // ifRightChekbox
            // 
            ifRightChekbox.AutoSize = true;
            ifRightChekbox.Location = new Point(50, 298);
            ifRightChekbox.Name = "ifRightChekbox";
            ifRightChekbox.Size = new Size(15, 14);
            ifRightChekbox.TabIndex = 13;
            ifRightChekbox.UseVisualStyleBackColor = true;
            // 
            // answerTextbox
            // 
            answerTextbox.Location = new Point(71, 262);
            answerTextbox.Name = "answerTextbox";
            answerTextbox.Size = new Size(235, 96);
            answerTextbox.TabIndex = 14;
            answerTextbox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 244);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 15;
            label5.Text = "Write answer here";
            // 
            // saveTestButton
            // 
            saveTestButton.Location = new Point(614, 462);
            saveTestButton.Name = "saveTestButton";
            saveTestButton.Size = new Size(75, 23);
            saveTestButton.TabIndex = 16;
            saveTestButton.Text = "Save test";
            saveTestButton.UseVisualStyleBackColor = true;
            saveTestButton.Click += saveTestButton_Click;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new Point(695, 462);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(75, 23);
            nextQuestionButton.TabIndex = 17;
            nextQuestionButton.Text = "Next";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += nextQuestionButton_Click;
            // 
            // deletePictureButton
            // 
            deletePictureButton.Location = new Point(614, 249);
            deletePictureButton.Name = "deletePictureButton";
            deletePictureButton.Size = new Size(156, 23);
            deletePictureButton.TabIndex = 18;
            deletePictureButton.Text = "Delete picture";
            deletePictureButton.UseVisualStyleBackColor = true;
            deletePictureButton.Click += deletePictureButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 318);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 19;
            label6.Text = "Added answers for this question";
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 493);
            Controls.Add(label6);
            Controls.Add(deletePictureButton);
            Controls.Add(nextQuestionButton);
            Controls.Add(saveTestButton);
            Controls.Add(label5);
            Controls.Add(answerTextbox);
            Controls.Add(ifRightChekbox);
            Controls.Add(answersListbox);
            Controls.Add(addAnswerButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addPictureButton);
            Controls.Add(label2);
            Controls.Add(questionTextbox);
            Controls.Add(label1);
            Controls.Add(weightNumber);
            Controls.Add(pictureBox1);
            Name = "EditingForm";
            Text = "EditingForm";
            Load += EditingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown weightNumber;
        private Label label1;
        private RichTextBox questionTextbox;
        private Label label2;
        private Button addPictureButton;
        private Label label3;
        private Label label4;
        private Button addAnswerButton;
        private OpenFileDialog openFileDialog1;
        private ListBox answersListbox;
        private CheckBox ifRightChekbox;
        private RichTextBox answerTextbox;
        private Label label5;
        private Button saveTestButton;
        private Button nextQuestionButton;
        private Button deletePictureButton;
        private Label label6;
    }
}