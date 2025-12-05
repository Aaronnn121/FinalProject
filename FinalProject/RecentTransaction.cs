using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Models; // Essential: Finds the definition for your 'User' model

namespace FinalProject
{
    public partial class RecentTransaction : Form
    {
        // repository instance
        private readonly RecentTransactionRepository repository = new RecentTransactionRepository();

        // Single-instance reference so other forms can refresh the view
        public static RecentTransaction Instance { get; private set; }

        public RecentTransaction()
        {
            InitializeComponent();
            Instance = this;
            LoadUsersToDataGridView();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Instance = null;
        }

        private void LoadUsersToDataGridView()
        {
            List<User> users = repository.GetAll();

            // Ensure your DataGridView control is named 'dgViewUsers' in the designer.
            dgViewUsers.DataSource = users;
            dgViewUsers.Refresh();
        }

        /// <summary>
        /// Public method called by other forms when new data is available.
        /// </summary>
        public void RefreshData()
        {
            LoadUsersToDataGridView();
        }

        private void dgViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(
                "Welcome to User Manager",
                "Greetings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You may remove this if it's not being used by any control.
        }
    }
}