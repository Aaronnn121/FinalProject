namespace FinalProject
{
    partial class LoginForm
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
            mainPanel = new Panel();
            label1 = new Label();
            loginButton = new RoundedButton();
            passwordTextBox = new RoundedTextBox();
            usernameTextBox = new RoundedTextBox();
            welcomeLabel = new Label();
            signInUpLabel = new Label();
            titleLabel = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(45, 52, 54);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(loginButton);
            mainPanel.Controls.Add(passwordTextBox);
            mainPanel.Controls.Add(usernameTextBox);
            mainPanel.Controls.Add(welcomeLabel);
            mainPanel.Controls.Add(signInUpLabel);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Location = new Point(20, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(288, 380);
            mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 236);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 7;
            label1.Text = "Create account";
            label1.Click += label1_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 188, 212);
            loginButton.CornerRadius = 20;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(30, 270);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click_1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(60, 68, 70);
            passwordTextBox.BorderColor = Color.FromArgb(100, 110, 115);
            passwordTextBox.BorderSize = 1;
            passwordTextBox.CornerRadius = 15;
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(30, 210);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(60, 68, 70);
            usernameTextBox.BorderColor = Color.FromArgb(100, 110, 115);
            usernameTextBox.BorderSize = 1;
            usernameTextBox.CornerRadius = 15;
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(30, 150);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(228, 23);
            usernameTextBox.TabIndex = 4;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(106, 80);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(74, 21);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome";
            // 
            // signInUpLabel
            // 
            signInUpLabel.AutoSize = true;
            signInUpLabel.Font = new Font("Segoe UI", 10F);
            signInUpLabel.ForeColor = Color.FromArgb(189, 195, 199);
            signInUpLabel.Location = new Point(95, 49);
            signInUpLabel.Name = "signInUpLabel";
            signInUpLabel.Size = new Size(101, 19);
            signInUpLabel.TabIndex = 2;
            signInUpLabel.Text = "Sign in/Sign up";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(95, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 30);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "MEEBank";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 240, 203);
            ClientSize = new Size(328, 450);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEEBank";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label titleLabel;
        private Label signInUpLabel;
        private Label welcomeLabel;
        private RoundedTextBox usernameTextBox;
        private RoundedTextBox passwordTextBox;
        private RoundedButton loginButton;
        private Label label1;
    }
}