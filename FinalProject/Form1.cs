using System;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        // File path to store user data
        private string userDataFile = "users.txt";

        public Form1()
        {
            InitializeComponent();
            // Set password character to hide input
            passwordTextBox.PasswordChar = '•';
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Remove any numbers from full name
            string text = fullNameTextBox.Text;
            string cleanedText = "";

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    cleanedText += c;
                }
            }

            if (text != cleanedText)
            {
                fullNameTextBox.Text = cleanedText;
                fullNameTextBox.SelectionStart = cleanedText.Length;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from username
            string text = usernameTextBox.Text;
            if (text.Contains(" "))
            {
                usernameTextBox.Text = text.Replace(" ", "");
                usernameTextBox.SelectionStart = usernameTextBox.Text.Length;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Change color based on password strength
            string password = passwordTextBox.Text;

            if (password.Length < 6)
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightCoral;
            }
            else if (password.Length < 8)
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightYellow;
            }
            else
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string fullName = fullNameTextBox.Text.Trim();
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // Validation
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullNameTextBox.Focus();
                return;
            }

            if (fullName.Length < 2)
            {
                MessageBox.Show("Full name must be at least 2 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullNameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Focus();
                return;
            }

            // Check if username already exists
            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
                return;
            }

            // Save user to file
            try
            {
                SaveUser(fullName, username, password);

                MessageBox.Show($"Account created successfully!\n\nWelcome to MEEBank, {fullName}!",
                    "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all fields
                ClearForm();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private bool UsernameExists(string username)
        {
            if (!File.Exists(userDataFile))
                return false;

            string[] lines = File.ReadAllLines(userDataFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 2 && parts[1].Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void SaveUser(string fullName, string username, string password)
        {
            // Format: FullName|Username|Password
            string userData = $"{fullName}|{username}|{password}";

            using (StreamWriter writer = new StreamWriter(userDataFile, true))
            {
                writer.WriteLine(userData);
            }
        }

        private void ClearForm()
        {
            fullNameTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            fullNameTextBox.Focus();
        }
    }
}