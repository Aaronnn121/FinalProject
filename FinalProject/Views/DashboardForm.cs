using System;
using System.Globalization;
using System.Security.Principal;
using System.Windows.Forms;
using FinalProject.Models;
using FinalProject.Respository;
using FinalProject.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject
{
    public partial class DashboardForm : Form
    {
        public decimal currentBalance = 1000m;
        private string _userName;
        private AccountModel _account;
        AccountRepository _repository;

        public DashboardForm(string userName)
        {
            InitializeComponent();
            _repository = new AccountRepository();

            _userName = userName;
            // _account = _repository.GetByUsername(_userName);

            UpdateUserNameLabel();

            // show initial balance
            UpdateBalanceLabel();

            // wire add-money click (designer didn't have it wired)
            addMoneyButton.Click += addMoneyButton_Click;
        }

        private void UpdateBalanceLabel()
        {
            // Display the current balance as currency
            balanceAmountLabel.Text = currentBalance.ToString("C");
            // Keep the other label in sync (designer includes two controls)
            balanceLabel.Text = currentBalance.ToString("C");
        }

        private void addMoneyButton_Click(object sender, EventArgs e)
        {
            decimal? amount = Prompt.ShowDecimal("Enter amount to add:", "Add Money");
            if (!amount.HasValue)
                return;

            if (amount.Value <= 0)
            {
                MessageBox.Show("Please enter a positive amount.", "Invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update balance and UI
            currentBalance += amount.Value;
            UpdateBalanceLabel();

            // Save to recent transactions repo
            var repo = new RecentTransactionRepository();
            var record = new User
            {
                FullName = _account?.FullName ?? _userName,
                AccountBalance = currentBalance,
                TransactionType = "Deposit",
                Amount = amount.Value
            };
            repo.SaveTransaction(record);

            // Refresh RecentTransaction form if it is open
            if (RecentTransaction.Instance != null)
            {
                RecentTransaction.Instance.RefreshData();
            }

            MessageBox.Show($"Successfully added {amount.Value:C} to your account.", "Add Money", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateUserNameLabel()
        {
            if (_account != null)
            {
                userNameLabel.Text = _account.FullName;
            }
            else
            {
                userNameLabel.Text = _userName;
            }
        }

        private void fundTransferButton_Click(object sender, EventArgs e)
        {
            SendMoneyForm dashboard = new SendMoneyForm(_account); // pass account info if needed
            dashboard.Show();
            this.Hide();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            //_account = _repository.GetByUsername(userNameLabel.Text);
            UpdateUserNameLabel();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // optional: refresh logic
        }
    }
}