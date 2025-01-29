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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            deleteTestButton = new Button();
            startTestButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addTestButton
            // 
            addTestButton.Location = new Point(12, 16);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(75, 23);
            addTestButton.TabIndex = 0;
            addTestButton.Text = "Add test";
            addTestButton.UseVisualStyleBackColor = true;
            addTestButton.Click += addTestButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(901, 12);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(75, 23);
            signOutButton.TabIndex = 1;
            signOutButton.Text = "Exit";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 319);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Available tests";
            // 
            // deleteTestButton
            // 
            deleteTestButton.Location = new Point(93, 16);
            deleteTestButton.Name = "deleteTestButton";
            deleteTestButton.Size = new Size(75, 23);
            deleteTestButton.TabIndex = 5;
            deleteTestButton.Text = "Delete test";
            deleteTestButton.UseVisualStyleBackColor = true;
            deleteTestButton.Click += deleteTestButton_Click;
            // 
            // startTestButton
            // 
            startTestButton.Location = new Point(12, 419);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(75, 23);
            startTestButton.TabIndex = 6;
            startTestButton.Text = "Start test";
            startTestButton.UseVisualStyleBackColor = true;
            startTestButton.Click += button1_Click;
            // 
            // ControlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 554);
            Controls.Add(startTestButton);
            Controls.Add(deleteTestButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(usernameInfo);
            Controls.Add(signOutButton);
            Controls.Add(addTestButton);
            Name = "ControlMenu";
            Text = "Control Menu";
            Load += ControlMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTestButton;
        private Button signOutButton;
        private Label usernameInfo;
        private DataGridView dataGridView1;
        private Label label1;
        private Button deleteTestButton;
        private Button startTestButton;
    }
}