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

                // Open next form (for example: dashboard)
                Form dashboard = new Form2();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}