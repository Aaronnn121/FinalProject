using System;
using System.Windows.Forms;
using FinalProject.Models;


namespace FinalProject
{
    public partial class SendMoneyForm : Form
    {
        public static SendMoneyForm Instance;

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
            Instance = this;
            amountTextBox.Text = " ";
        }


        private void transferButton_Click(object sender, EventArgs e)
        {
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

            TransactionModel transaction = new TransactionModel();
            transaction.Sender = _loggedInAccount;
            transaction.Receiver = new AccountModel { FullName = recipientTextBox.Text.Trim() };

            transaction.Amount = (double)amount;

            Form5 dashboard = new Form5(transaction);
            dashboard.Show();
            this.Hide();

            amountTextBox.Clear();
            amountTextBox.Focus();
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

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}