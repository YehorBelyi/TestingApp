namespace TestingApp.Main_Menus.ProgressMenu
{
    partial class ProgressMenu
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            averageMarkTextBox = new TextBox();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 0;
            label1.Text = "Tests you passed";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(481, 289);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(147, 363);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 2;
            label2.Text = "Your average mark";
            // 
            // averageMarkTextBox
            // 
            averageMarkTextBox.Location = new Point(207, 398);
            averageMarkTextBox.Name = "averageMarkTextBox";
            averageMarkTextBox.ReadOnly = true;
            averageMarkTextBox.Size = new Size(100, 23);
            averageMarkTextBox.TabIndex = 3;
            averageMarkTextBox.TextChanged += averageMarkTextBox_TextChanged;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(12, 439);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(481, 43);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ProgressMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 502);
            Controls.Add(closeButton);
            Controls.Add(averageMarkTextBox);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ProgressMenu";
            Text = "Progress Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox averageMarkTextBox;
        private Button closeButton;
    }
}