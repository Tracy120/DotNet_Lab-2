namespace Assignment_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(55, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(408, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Bicycle Rental and Mushroom App";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(55, 95);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(55, 140);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(150, 90);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(210, 27);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(150, 135);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(210, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(150, 185);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 30);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 300);
            Controls.Add(titleLabel);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 1 - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
