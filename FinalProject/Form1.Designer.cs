using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Form1
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
            nameTextBox = new RoundedTextBox();
            emailTextBox = new RoundedTextBox();
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
            mainPanel.Controls.Add(nameTextBox);
            mainPanel.Controls.Add(emailTextBox);
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
            titleLabel.Location = new Point(91, 20);
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
            signInUpLabel.Location = new Point(96, 60);
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
            welcomeLabel.Location = new Point(109, 85);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(74, 21);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(60, 68, 70);
            nameTextBox.BorderColor = Color.FromArgb(189, 195, 199);
            nameTextBox.BorderSize = 1;
            nameTextBox.CornerRadius = 15;
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(30, 120);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(228, 23);
            nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(60, 68, 70);
            emailTextBox.BorderColor = Color.FromArgb(189, 195, 199);
            emailTextBox.BorderSize = 1;
            emailTextBox.CornerRadius = 15;
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(30, 180);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(228, 23);
            emailTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(60, 68, 70);
            passwordTextBox.BorderColor = Color.FromArgb(189, 195, 199);
            passwordTextBox.BorderSize = 1;
            passwordTextBox.CornerRadius = 15;
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(30, 240);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(0, 188, 212);
            signUpButton.CornerRadius = 20;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(30, 300);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(228, 40);
            signUpButton.TabIndex = 7;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 240, 203);
            ClientSize = new Size(328, 450);
            Controls.Add(mainPanel);
            Name = "Form1";
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
        private RoundedTextBox nameTextBox;
        private RoundedTextBox emailTextBox;
        private RoundedTextBox passwordTextBox;
        private RoundedButton signUpButton;
    }

    // Custom rounded textbox control
    public class RoundedTextBox : TextBox
    {
        private Color _borderColor = Color.White;
        private int _borderSize = 1;
        private int _cornerRadius = 15;
        private string _placeholderText = "";

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

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set { _placeholderText = value; Invalidate(); }
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

            // Draw placeholder text if needed
            if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(_placeholderText))
            {
                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(g, _placeholderText, new Font(Font.FontFamily, Font.Size, FontStyle.Italic),
                    new Rectangle(5, 0, Width - 10, Height), Color.Gray, flags);
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