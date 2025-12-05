using System;
using System.Windows.Forms;
using FinalProject.Models;

namespace FinalProject
{
    public partial class Form5 : Form
    {
        private readonly TransactionModel _transaction;

        public Form5(TransactionModel transaction)
        {
            InitializeComponent();
            _transaction = transaction;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (_transaction.Receiver != null)
            {
                receiverValueLabel.Text = _transaction.Receiver.FullName;
            }
            else
            {
                receiverValueLabel.Text = "Unknown Receiver";
            }

            // Using the current system time for display
            dateTimeValueLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");

            if (_transaction.Amount > 0)
            {
                // "C" formats the amount as currency based on the current culture
                amountValueLabel.Text = _transaction.Amount.ToString("C");
            }
            else
            {
                amountValueLabel.Text = "No amount set";
            }
        }

        // --- Other event handlers (omitted for brevity) ---
        private void dateTimeValueLabel_Click(object sender, EventArgs e)
        {
        }

        private void receiverValueLabel_Click(object sender, EventArgs e)
        {
        }

        private void dateTimeValueLabel_Click_1(object sender, EventArgs e)
        {
        }

        private void amountValueLabel_Click(object sender, EventArgs e)
        {

        }
        // --- End of other event handlers ---


        /// <summary>
        /// Navigates to the Recent Transactions Form (assumed to be Form6).
        /// </summary>
        private void recentTransactionButton_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the new form (e.g., Form6 for recent transactions)
            // You might need to pass data to Form6, depending on its requirements.
            // For simplicity, we are assuming Form6 has a default constructor.
            Form RecentTransaction = new RecentTransaction(); // **Replace 'Form6' with the actual name of your recent transactions form**

            // 2. Show the new form
            RecentTransaction.Show();

            // 3. (Optional but recommended for form navigation) Hide the current form
            this.Hide();

            // OR: Close the current form if you don't need to return to it.
            // this.Close();
        }
    }
}