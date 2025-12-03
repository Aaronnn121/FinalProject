using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation, placeholder behavior, etc.
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: hide password with bullets, etc.
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text.Trim();
            string pass = passwordTextBox.Text.Trim();

            // Simple example credential check
            if (user == "admin" && pass == "1234")
            {
                MessageBox.Show("Login successful!", "MEEBank",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open next form (Form3) instead of Form2
                Form dashboard = new Form3();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Form1 dashboard = new Form1();
            dashboard.Show();

            this.Hide();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
          
            string user = usernameTextBox.Text.Trim();
            string pass = passwordTextBox.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateCredentials(user, pass))
            {
                MessageBox.Show("Login successful!", "MEEBank",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form dashboard = new Form3();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateCredentials(string username, string password)
        {
            string path = Path.Combine(Application.StartupPath, "users.txt");
            if (!File.Exists(path))
                return false;

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split('|');
                if (parts.Length >= 3 &&
                    string.Equals(parts[1], username, StringComparison.OrdinalIgnoreCase) &&
                    parts[2] == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
    
}