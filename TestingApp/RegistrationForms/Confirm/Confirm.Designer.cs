namespace TestingApp.RegistrationForms.Confirm
{
    partial class Confirm
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
            emailRow = new Label();
            confirmBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // emailRow
            // 
            emailRow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailRow.AutoSize = true;
            emailRow.Location = new Point(111, 68);
            emailRow.Name = "emailRow";
            emailRow.Size = new Size(32, 15);
            emailRow.TabIndex = 0;
            emailRow.Text = "TEXT";
            emailRow.TextAlign = ContentAlignment.MiddleCenter;
            emailRow.Click += label1_Click;
            // 
            // confirmBox
            // 
            confirmBox.Location = new Point(178, 110);
            confirmBox.Name = "confirmBox";
            confirmBox.Size = new Size(124, 23);
            confirmBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(202, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Confirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 212);
            Controls.Add(button1);
            Controls.Add(confirmBox);
            Controls.Add(emailRow);
            Name = "Confirm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailRow;
        private TextBox confirmBox;
        private Button button1;
    }
}