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
            oneAnswerRadio = new RadioButton();
            manyAnswersRadio = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(705, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 201);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // oneAnswerRadio
            // 
            oneAnswerRadio.AutoSize = true;
            oneAnswerRadio.Location = new Point(12, 13);
            oneAnswerRadio.Name = "oneAnswerRadio";
            oneAnswerRadio.Size = new Size(87, 19);
            oneAnswerRadio.TabIndex = 2;
            oneAnswerRadio.TabStop = true;
            oneAnswerRadio.Text = "One answer";
            oneAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // manyAnswersRadio
            // 
            manyAnswersRadio.AutoSize = true;
            manyAnswersRadio.Location = new Point(12, 38);
            manyAnswersRadio.Name = "manyAnswersRadio";
            manyAnswersRadio.Size = new Size(100, 19);
            manyAnswersRadio.TabIndex = 3;
            manyAnswersRadio.TabStop = true;
            manyAnswersRadio.Text = "Many answers";
            manyAnswersRadio.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 106);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(134, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 5;
            label1.Text = "Weight for this question";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(268, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(341, 161);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(317, 13);
            label2.Name = "label2";
            label2.Size = new Size(241, 30);
            label2.TabIndex = 7;
            label2.Text = "Enter your question here";
            // 
            // button1
            // 
            button1.Location = new Point(795, 249);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 8;
            button1.Text = "Choose picture";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(765, 216);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 9;
            label3.Text = "You can attach a picture to the question";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(840, 231);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "<optional>";
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 513);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(manyAnswersRadio);
            Controls.Add(oneAnswerRadio);
            Controls.Add(pictureBox1);
            Name = "EditingForm";
            Text = "EditingForm";
            Load += EditingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton oneAnswerRadio;
        private RadioButton manyAnswersRadio;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}