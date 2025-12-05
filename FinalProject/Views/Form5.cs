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

            dateTimeValueLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");

            if (_transaction.Amount > 0)
            {
                amountValueLabel.Text = _transaction.Amount.ToString("C");
            }
            else
            {
                amountValueLabel.Text = "No amount set";
            }
        }

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

        private void recentTransactionButton_Click(object sender, EventArgs e)
        {

        }
    }
}