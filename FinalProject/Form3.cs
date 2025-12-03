using System;
using System.Globalization;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {

        public decimal currentBalance = 1000m;

        public Form3()
        {
            InitializeComponent();
        }

        private void fundTransferButton_Click(object sender, EventArgs e)
        {

            Form4 dashboard = new Form4();
            dashboard.Show();

            this.Hide();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
