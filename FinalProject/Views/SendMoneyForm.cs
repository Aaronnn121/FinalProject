using System;
using System.Windows.Forms;
using FinalProject.Models;


namespace FinalProject
{

 

    // In Form4.cs (your partial class)
    public partial class SendMoneyForm : Form
    {
        public static SendMoneyForm Instance;  // NEW: Global access from Form3

        // NEW: Public properties to "read/write" UI safely (no private hacks)
        private AccountModel _loggedInAccount;

        public string RecipientLabelText
        {
            get => amountTextBox.Text;
            set => amountTextBox.Text = value;
        }

        public SendMoneyForm(AccountModel accountModel)
        {
            InitializeComponent();
            _loggedInAccount = accountModel;
            Instance = this;  // NEW: Register instance
            amountTextBox.Text = " ";  // Starting
        }

        
            private void transferButton_Click(object sender, EventArgs e)
        {
            // Validate the amount entered in the amountTextBox
            if (!decimal.TryParse(amountTextBox.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount to transfer.",
                                "Invalid Amount",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                amountTextBox.Focus();
                amountTextBox.SelectAll();
                return;
            }

            // Perform transfer logic (dummy message for now)
            
            // Clear the input field after transfer
            amountTextBox.Clear();
            amountTextBox.Focus();

            TransactionModel transaction = new TransactionModel();
            transaction.Sender = _loggedInAccount;
            transaction.Receiver = new AccountModel { FullName = recipientTextBox.Text.Trim() };

            Form5 dashboard = new Form5(transaction);
            dashboard.Show();

            this.Hide();

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