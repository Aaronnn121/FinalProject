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

// CRITICAL FIX: The conflicting 'using Microsoft.VisualBasic.ApplicationServices;' 
// is omitted to prevent the "ambiguous reference" error for the 'User' type.

namespace FinalProject
{
    public partial class RecentTransaction : Form
    {
        // FIX: Correctly instantiate the dedicated Repository class
        private readonly RecentTransactionRepository repository = new RecentTransactionRepository();

        public RecentTransaction()
        {
            InitializeComponent();
            LoadUsersToDataGridView();
        }

        private void LoadUsersToDataGridView()
        {
            List<User> users = repository.GetAll();

            // NOTE: Ensure your DataGridView control is named 'dgViewUsers' in the designer.
            dgViewUsers.DataSource = users;

            // CRITICAL: Force the DataGridView to redraw and display changes
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