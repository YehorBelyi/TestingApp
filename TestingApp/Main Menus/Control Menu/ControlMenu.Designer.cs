namespace TestingApp.MainMenu
{
    partial class ControlMenu
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
            addTestButton = new Button();
            signOutButton = new Button();
            usernameInfo = new Label();
            SuspendLayout();
            // 
            // addTestButton
            // 
            addTestButton.Location = new Point(12, 12);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(75, 23);
            addTestButton.TabIndex = 0;
            addTestButton.Text = "Add test";
            addTestButton.UseVisualStyleBackColor = true;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(901, 12);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(75, 23);
            signOutButton.TabIndex = 1;
            signOutButton.Text = "Exit";
            signOutButton.UseVisualStyleBackColor = true;
            // 
            // usernameInfo
            // 
            usernameInfo.AutoSize = true;
            usernameInfo.ForeColor = Color.IndianRed;
            usernameInfo.Location = new Point(768, 16);
            usernameInfo.Name = "usernameInfo";
            usernameInfo.Size = new Size(115, 15);
            usernameInfo.TabIndex = 2;
            usernameInfo.Text = "Welcome, username";
            // 
            // ControlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 554);
            Controls.Add(usernameInfo);
            Controls.Add(signOutButton);
            Controls.Add(addTestButton);
            Name = "ControlMenu";
            Text = "Control Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTestButton;
        private Button signOutButton;
        private Label usernameInfo;
    }
}