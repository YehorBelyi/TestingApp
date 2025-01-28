namespace TestingApp.Main_Menus.AddForms.AddConfirmation
{
    partial class AddConfirmation
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
            nameTestbox = new TextBox();
            label2 = new Label();
            descTextbox = new TextBox();
            addTestButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Specify name of the test";
            // 
            // nameTestbox
            // 
            nameTestbox.Location = new Point(152, 15);
            nameTestbox.Name = "nameTestbox";
            nameTestbox.Size = new Size(324, 23);
            nameTestbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Description of the test";
            // 
            // descTextbox
            // 
            descTextbox.Location = new Point(152, 55);
            descTextbox.Name = "descTextbox";
            descTextbox.Size = new Size(324, 23);
            descTextbox.TabIndex = 3;
            // 
            // addTestButton
            // 
            addTestButton.Location = new Point(162, 100);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(199, 23);
            addTestButton.TabIndex = 4;
            addTestButton.Text = "Add test";
            addTestButton.UseVisualStyleBackColor = true;
            addTestButton.Click += addTestButton_Click;
            // 
            // AddConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 135);
            Controls.Add(addTestButton);
            Controls.Add(descTextbox);
            Controls.Add(label2);
            Controls.Add(nameTestbox);
            Controls.Add(label1);
            Name = "AddConfirmation";
            Text = "AddConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTestbox;
        private Label label2;
        private TextBox descTextbox;
        private Button addTestButton;
    }
}