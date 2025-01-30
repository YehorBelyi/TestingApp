
namespace TestingApp.RegistrationForms.Login
{
    partial class Login
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
            loginBox = new TextBox();
            label1 = new Label();
            passwordBox = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            registerLink = new LinkLabel();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Location = new Point(192, 88);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(203, 23);
            loginBox.TabIndex = 0;
            loginBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 70);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your login";
            label1.Click += label1_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(192, 149);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(203, 23);
            passwordBox.TabIndex = 2;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 131);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter your password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(251, 178);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(91, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Sign in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.Location = new Point(205, 204);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(179, 15);
            registerLink.TabIndex = 5;
            registerLink.TabStop = true;
            registerLink.Text = "Don't have an accout? Register it";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 307);
            Controls.Add(registerLink);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordBox);
            Controls.Add(label1);
            Controls.Add(loginBox);
            Name = "Login";
            Text = "LoginForm";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private TextBox loginBox;
        private Label label1;
        private TextBox passwordBox;
        private Label label2;
        private Button loginButton;
        private LinkLabel registerLink;
    }
}