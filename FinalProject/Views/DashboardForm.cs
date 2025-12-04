using System;
using System.Globalization;
using System.Security.Principal;
using System.Windows.Forms;
using FinalProject.Models;
using FinalProject.Respository;
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
            _account = _repository.GetByUsername(_userName);

            UpdateUserNameLabel();
        }
        private void UpdateUserNameLabel()
        {
            if (_account != null)
            {
                userNameLabel.Text = _account.FullName;
            }
            else
            {
                userNameLabel.Text = "Unknown User";
                // Optional: log warning or disable functionality that depends on a valid account.
            }
        }



        private void fundTransferButton_Click(object sender, EventArgs e)
        {

            SendMoneyForm dashboard = new SendMoneyForm(_account);//pass account info if needed
            dashboard.Show();

            this.Hide();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            _account = _repository.GetByUsername(userNameLabel.Text);
            UpdateUserNameLabel();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}