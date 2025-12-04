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
        }
    }
}