namespace TestingApp.Main_Menus.TestEdit
{
    partial class TestEdit
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
            label1 = new Label();
            testNameTextbox = new TextBox();
            label2 = new Label();
            testDescTextbox = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            editQuestionButton = new Button();
            saveChangesButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Name of the test";
            // 
            // testNameTextbox
            // 
            testNameTextbox.Location = new Point(138, 9);
            testNameTextbox.Name = "testNameTextbox";
            testNameTextbox.Size = new Size(650, 23);
            testNameTextbox.TabIndex = 1;
            testNameTextbox.TextChanged += testNameTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 2;
            label2.Text = "Description of the test";
            // 
            // testDescTextbox
            // 
            testDescTextbox.Location = new Point(174, 47);
            testDescTextbox.Name = "testDescTextbox";
            testDescTextbox.Size = new Size(614, 23);
            testDescTextbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 4;
            label3.Text = "Questions in the test to edit";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 253);
            dataGridView1.TabIndex = 5;
            // 
            // editQuestionButton
            // 
            editQuestionButton.Location = new Point(12, 369);
            editQuestionButton.Name = "editQuestionButton";
            editQuestionButton.Size = new Size(776, 40);
            editQuestionButton.TabIndex = 6;
            editQuestionButton.Text = "Edit question";
            editQuestionButton.UseVisualStyleBackColor = true;
            editQuestionButton.Click += editQuestionButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(12, 415);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(776, 40);
            saveChangesButton.TabIndex = 7;
            saveChangesButton.Text = "Save changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 461);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(776, 40);
            exitButton.TabIndex = 8;
            exitButton.Text = "Close window";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // TestEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(exitButton);
            Controls.Add(saveChangesButton);
            Controls.Add(editQuestionButton);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(testDescTextbox);
            Controls.Add(label2);
            Controls.Add(testNameTextbox);
            Controls.Add(label1);
            Name = "TestEdit";
            Text = "TestEdit";
            Load += TestEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox testNameTextbox;
        private Label label2;
        private TextBox testDescTextbox;
        private Label label3;
        private DataGridView dataGridView1;
        private Button editQuestionButton;
        private Button saveChangesButton;
        private Button exitButton;
    }
}