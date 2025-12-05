using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FinalProject
{
    partial class SignupForm
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
            titleLabel = new Label();
            signInUpLabel = new Label();
            welcomeLabel = new Label();
            fullNameLabel = new Label();
            fullNameTextBox = new RoundedTextBox();
            usernameLabel = new Label();
            usernameTextBox = new RoundedTextBox();
            passwordLabel = new Label();
            passwordTextBox = new RoundedTextBox();
            signUpButton = new RoundedButton();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(45, 52, 54);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(signInUpLabel);
            mainPanel.Controls.Add(welcomeLabel);
            mainPanel.Controls.Add(fullNameLabel);
            mainPanel.Controls.Add(fullNameTextBox);
            mainPanel.Controls.Add(usernameLabel);
            mainPanel.Controls.Add(usernameTextBox);
            mainPanel.Controls.Add(passwordLabel);
            mainPanel.Controls.Add(passwordTextBox);
            mainPanel.Controls.Add(signUpButton);
            mainPanel.Location = new Point(20, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(288, 380);
            mainPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(87, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 30);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "MEEBank";
            // 
            // signInUpLabel
            // 
            signInUpLabel.AutoSize = true;
            signInUpLabel.Font = new Font("Segoe UI", 10F);
            signInUpLabel.ForeColor = Color.FromArgb(189, 195, 199);
            signInUpLabel.Location = new Point(90, 60);
            signInUpLabel.Name = "signInUpLabel";
            signInUpLabel.Size = new Size(101, 19);
            signInUpLabel.TabIndex = 2;
            signInUpLabel.Text = "Sign in/Sign up";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(105, 85);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(74, 21);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 9F);
            fullNameLabel.ForeColor = Color.FromArgb(189, 195, 199);
            fullNameLabel.Location = new Point(30, 125);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(61, 15);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = Color.FromArgb(60, 68, 70);
            fullNameTextBox.BorderColor = Color.FromArgb(100, 110, 115);
            fullNameTextBox.BorderSize = 1;
            fullNameTextBox.CornerRadius = 15;
            fullNameTextBox.ForeColor = Color.White;
            fullNameTextBox.Location = new Point(30, 145);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(228, 23);
            fullNameTextBox.TabIndex = 5;
            fullNameTextBox.TextChanged += fullNameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F);
            usernameLabel.ForeColor = Color.FromArgb(189, 195, 199);
            usernameLabel.Location = new Point(30, 195);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(60, 68, 70);
            usernameTextBox.BorderColor = Color.FromArgb(100, 110, 115);
            usernameTextBox.BorderSize = 1;
            usernameTextBox.CornerRadius = 15;
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(30, 215);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(228, 23);
            usernameTextBox.TabIndex = 7;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F);
            passwordLabel.ForeColor = Color.FromArgb(189, 195, 199);
            passwordLabel.Location = new Point(30, 265);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(60, 68, 70);
            passwordTextBox.BorderColor = Color.FromArgb(100, 110, 115);
            passwordTextBox.BorderSize = 1;
            passwordTextBox.CornerRadius = 15;
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(30, 285);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 9;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(0, 188, 212);
            signUpButton.CornerRadius = 20;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(30, 330);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(228, 40);
            signUpButton.TabIndex = 10;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 240, 203);
            ClientSize = new Size(328, 450);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEEBank";
            Load += SignupForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label titleLabel;
        private Label signInUpLabel;
        private Label welcomeLabel;
        private Label fullNameLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private RoundedTextBox fullNameTextBox;
        private RoundedTextBox usernameTextBox;
        private RoundedTextBox passwordTextBox;
        private RoundedButton signUpButton;
    }

    // Custom rounded textbox control (Placeholder text logic removed)
    public class RoundedTextBox : TextBox
    {
        private Color _borderColor = Color.White;
        private int _borderSize = 1;
        private int _cornerRadius = 15;

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = value; Invalidate(); }
        }

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw border
            using (Pen pen = new Pen(_borderColor, _borderSize))
            {
                g.DrawPath(pen, GetRoundedRectPath(ClientRectangle, _cornerRadius));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = new Region(GetRoundedRectPath(ClientRectangle, _cornerRadius));
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);

            // Top right corner
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right corner
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left corner
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

    // Custom rounded button control
    public class RoundedButton : Button
    {
        private int _cornerRadius = 20;

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath path = GetRoundedRectPath(rect, _cornerRadius);

            this.Region = new Region(path);

            using (Pen pen = new Pen(BackColor, 0))
            {
                g.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);

            // Top right corner
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right corner
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left corner
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}