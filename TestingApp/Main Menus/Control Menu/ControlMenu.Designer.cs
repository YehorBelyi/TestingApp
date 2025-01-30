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
            progressButton = new Button();
            editTestButton = new Button();
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
            signOutButton.Location = new Point(512, 16);
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
            usernameInfo.Location = new Point(379, 20);
            usernameInfo.Name = "usernameInfo";
            usernameInfo.Size = new Size(115, 15);
            usernameInfo.TabIndex = 2;
            usernameInfo.Text = "Welcome, username";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 319);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(209, 58);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 4;
            label1.Text = "Available tests";
            // 
            // deleteTestButton
            // 
            deleteTestButton.Location = new Point(174, 16);
            deleteTestButton.Name = "deleteTestButton";
            deleteTestButton.Size = new Size(75, 23);
            deleteTestButton.TabIndex = 5;
            deleteTestButton.Text = "Delete test";
            deleteTestButton.UseVisualStyleBackColor = true;
            deleteTestButton.Click += deleteTestButton_Click;
            // 
            // startTestButton
            // 
            startTestButton.Location = new Point(12, 418);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(575, 40);
            startTestButton.TabIndex = 6;
            startTestButton.Text = "Start test";
            startTestButton.UseVisualStyleBackColor = true;
            startTestButton.Click += button1_Click;
            // 
            // progressButton
            // 
            progressButton.Location = new Point(12, 464);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(575, 40);
            progressButton.TabIndex = 7;
            progressButton.Text = "Check your progress";
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // editTestButton
            // 
            editTestButton.Location = new Point(93, 16);
            editTestButton.Name = "editTestButton";
            editTestButton.Size = new Size(75, 23);
            editTestButton.TabIndex = 8;
            editTestButton.Text = "Edit test";
            editTestButton.UseVisualStyleBackColor = true;
            editTestButton.Click += editTestButton_Click;
            // 
            // ControlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 522);
            Controls.Add(editTestButton);
            Controls.Add(progressButton);
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
        private Button progressButton;
        private Button editTestButton;
    }
}