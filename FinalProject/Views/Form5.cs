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
            receiverValueLabel.Text = _transaction.Receiver.FullName;
            DateTime dateTime = DateTime.Now;
            dateTimeValueLabel.Text = dateTime.ToString("MMMM dd, yyyy hh:mm tt");

        }

        private void dateTimeValueLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}