using System;
using System.Windows.Forms;

namespace FinalProject
{
    // In Form4.cs (your partial class)
    public partial class Form4 : Form
    {
        public static Form4 Instance;  // NEW: Global access from Form3

        // NEW: Public properties to "read/write" UI safely (no private hacks)

        public string RecipientLabelText
        {
            get => amountTextBox.Text;
            set => amountTextBox.Text = value;
        }

        public Form4()
        {
            InitializeComponent();
            Instance = this;  // NEW: Register instance
            amountTextBox.Text = "1000.00";  // Starting
        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void contact1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipientTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}