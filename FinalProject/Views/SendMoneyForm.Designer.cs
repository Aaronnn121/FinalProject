using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    partial class SendMoneyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMoneyForm));
            titleLabel = new Label();
            contactLabel = new Label();
            recipientTextBox = new RoundedTextBox();
            recentLabel = new Label();
            seeAllLabel = new Label();
            contactPanel = new Panel();
            contact1Panel = new Panel();
            contact1NameLabel = new Label();
            contact1PhoneLabel = new Label();
            contact2Panel = new Panel();
            contact2NameLabel = new Label();
            contact2PhoneLabel = new Label();
            setAmountLabel = new Label();
            amountSubLabel = new Label();
            amountTextBox = new RoundedTextBox();
            transferButton = new RoundedButton();
            balanceAmountLabel = new RoundedTextBox();
            label1 = new Label();
            contactPanel.SuspendLayout();
            contact1Panel.SuspendLayout();
            contact2Panel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(45, 52, 54);
            titleLabel.Location = new Point(112, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(154, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Fund Transfer";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.BackColor = Color.Transparent;
            contactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contactLabel.ForeColor = Color.FromArgb(45, 52, 54);
            contactLabel.Location = new Point(20, 178);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(69, 21);
            contactLabel.TabIndex = 1;
            contactLabel.Text = "Contact";
            // 
            // recipientTextBox
            // 
            recipientTextBox.BackColor = Color.FromArgb(245, 245, 245);
            recipientTextBox.BorderColor = Color.White;
            recipientTextBox.BorderSize = 1;
            recipientTextBox.CornerRadius = 15;
            recipientTextBox.Font = new Font("Segoe UI", 10F);
            recipientTextBox.Location = new Point(20, 208);
            recipientTextBox.Name = "recipientTextBox";
            recipientTextBox.Size = new Size(335, 25);
            recipientTextBox.TabIndex = 2;
            recipientTextBox.TextChanged += recipientTextBox_TextChanged;
            // 
            // recentLabel
            // 
            recentLabel.AutoSize = true;
            recentLabel.BackColor = Color.Transparent;
            recentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            recentLabel.ForeColor = Color.FromArgb(45, 52, 54);
            recentLabel.Location = new Point(20, 243);
            recentLabel.Name = "recentLabel";
            recentLabel.Size = new Size(62, 21);
            recentLabel.TabIndex = 3;
            recentLabel.Text = "Recent";
            // 
            // seeAllLabel
            // 
            seeAllLabel.AutoSize = true;
            seeAllLabel.BackColor = Color.Transparent;
            seeAllLabel.Cursor = Cursors.Hand;
            seeAllLabel.Font = new Font("Segoe UI", 9F);
            seeAllLabel.ForeColor = Color.DarkGreen;
            seeAllLabel.Location = new Point(280, 246);
            seeAllLabel.Name = "seeAllLabel";
            seeAllLabel.Size = new Size(83, 15);
            seeAllLabel.TabIndex = 4;
            seeAllLabel.Text = "See all contact";
            // 
            // contactPanel
            // 
            contactPanel.BackColor = Color.White;
            contactPanel.Controls.Add(contact1Panel);
            contactPanel.Controls.Add(contact2Panel);
            contactPanel.Location = new Point(20, 273);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(335, 180);
            contactPanel.TabIndex = 5;
            // 
            // contact1Panel
            // 
            contact1Panel.BackColor = Color.FromArgb(245, 245, 245);
            contact1Panel.Controls.Add(contact1NameLabel);
            contact1Panel.Controls.Add(contact1PhoneLabel);
            contact1Panel.Cursor = Cursors.Hand;
            contact1Panel.Location = new Point(0, 10);
            contact1Panel.Name = "contact1Panel";
            contact1Panel.Size = new Size(335, 70);
            contact1Panel.TabIndex = 0;
            contact1Panel.Paint += contact1Panel_Paint;
            // 
            // contact1NameLabel
            // 
            contact1NameLabel.AutoSize = true;
            contact1NameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            contact1NameLabel.ForeColor = Color.FromArgb(45, 52, 54);
            contact1NameLabel.Location = new Point(15, 15);
            contact1NameLabel.Name = "contact1NameLabel";
            contact1NameLabel.Size = new Size(161, 20);
            contact1NameLabel.TabIndex = 0;
            contact1NameLabel.Text = "Jhunery Marc Pascual";
            // 
            // contact1PhoneLabel
            // 
            contact1PhoneLabel.AutoSize = true;
            contact1PhoneLabel.Font = new Font("Segoe UI", 9F);
            contact1PhoneLabel.ForeColor = Color.FromArgb(127, 140, 141);
            contact1PhoneLabel.Location = new Point(15, 40);
            contact1PhoneLabel.Name = "contact1PhoneLabel";
            contact1PhoneLabel.Size = new Size(73, 15);
            contact1PhoneLabel.TabIndex = 1;
            contact1PhoneLabel.Text = "09990364060";
            // 
            // contact2Panel
            // 
            contact2Panel.BackColor = Color.FromArgb(245, 245, 245);
            contact2Panel.Controls.Add(contact2NameLabel);
            contact2Panel.Controls.Add(contact2PhoneLabel);
            contact2Panel.Cursor = Cursors.Hand;
            contact2Panel.Location = new Point(0, 90);
            contact2Panel.Name = "contact2Panel";
            contact2Panel.Size = new Size(335, 70);
            contact2Panel.TabIndex = 1;
            // 
            // contact2NameLabel
            // 
            contact2NameLabel.AutoSize = true;
            contact2NameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            contact2NameLabel.ForeColor = Color.FromArgb(45, 52, 54);
            contact2NameLabel.Location = new Point(15, 15);
            contact2NameLabel.Name = "contact2NameLabel";
            contact2NameLabel.Size = new Size(159, 20);
            contact2NameLabel.TabIndex = 0;
            contact2NameLabel.Text = "Mark Aaron Estanoco";
            // 
            // contact2PhoneLabel
            // 
            contact2PhoneLabel.AutoSize = true;
            contact2PhoneLabel.Font = new Font("Segoe UI", 9F);
            contact2PhoneLabel.ForeColor = Color.FromArgb(127, 140, 141);
            contact2PhoneLabel.Location = new Point(15, 40);
            contact2PhoneLabel.Name = "contact2PhoneLabel";
            contact2PhoneLabel.Size = new Size(73, 15);
            contact2PhoneLabel.TabIndex = 1;
            contact2PhoneLabel.Text = "09572887390";
            // 
            // setAmountLabel
            // 
            setAmountLabel.AutoSize = true;
            setAmountLabel.BackColor = Color.Transparent;
            setAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            setAmountLabel.ForeColor = Color.FromArgb(45, 52, 54);
            setAmountLabel.Location = new Point(20, 464);
            setAmountLabel.Name = "setAmountLabel";
            setAmountLabel.Size = new Size(98, 21);
            setAmountLabel.TabIndex = 6;
            setAmountLabel.Text = "Set amount";
            // 
            // amountSubLabel
            // 
            amountSubLabel.AutoSize = true;
            amountSubLabel.BackColor = Color.Transparent;
            amountSubLabel.Font = new Font("Segoe UI", 9F);
            amountSubLabel.ForeColor = Color.FromArgb(127, 140, 141);
            amountSubLabel.Location = new Point(20, 489);
            amountSubLabel.Name = "amountSubLabel";
            amountSubLabel.Size = new Size(210, 15);
            amountSubLabel.TabIndex = 7;
            amountSubLabel.Text = "How much would you like to Transfer?";
            // 
            // amountTextBox
            // 
            amountTextBox.BackColor = Color.FromArgb(245, 245, 245);
            amountTextBox.BorderColor = Color.White;
            amountTextBox.BorderSize = 1;
            amountTextBox.CornerRadius = 15;
            amountTextBox.Font = new Font("Segoe UI", 12F);
            amountTextBox.Location = new Point(20, 514);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(335, 29);
            amountTextBox.TabIndex = 8;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // transferButton
            // 
            transferButton.BackColor = Color.FromArgb(0, 188, 212);
            transferButton.CornerRadius = 20;
            transferButton.FlatStyle = FlatStyle.Flat;
            transferButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            transferButton.ForeColor = Color.Transparent;
            transferButton.Location = new Point(20, 567);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(335, 50);
            transferButton.TabIndex = 9;
            transferButton.Text = "Fund Transfer";
            transferButton.UseVisualStyleBackColor = false;
            transferButton.Click += transferButton_Click;
            // 
            // balanceAmountLabel
            // 
            balanceAmountLabel.BackColor = Color.FromArgb(245, 245, 245);
            balanceAmountLabel.BorderColor = Color.White;
            balanceAmountLabel.BorderSize = 1;
            balanceAmountLabel.CornerRadius = 15;
            balanceAmountLabel.Font = new Font("Segoe UI", 12F);
            balanceAmountLabel.Location = new Point(20, 126);
            balanceAmountLabel.Name = "balanceAmountLabel";
            balanceAmountLabel.Size = new Size(335, 29);
            balanceAmountLabel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 52, 54);
            label1.Location = new Point(20, 102);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 11;
            label1.Text = "Current Balance";
            // 
            // SendMoneyForm
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 667);
            Controls.Add(label1);
            Controls.Add(balanceAmountLabel);
            Controls.Add(titleLabel);
            Controls.Add(contactLabel);
            Controls.Add(recipientTextBox);
            Controls.Add(recentLabel);
            Controls.Add(seeAllLabel);
            Controls.Add(contactPanel);
            Controls.Add(setAmountLabel);
            Controls.Add(amountSubLabel);
            Controls.Add(amountTextBox);
            Controls.Add(transferButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SendMoneyForm";
            Text = "Fund Transfer";
            Load += Form4_Load;
            contactPanel.ResumeLayout(false);
            contact1Panel.ResumeLayout(false);
            contact1Panel.PerformLayout();
            contact2Panel.ResumeLayout(false);
            contact2Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label contactLabel;
        private RoundedTextBox recipientTextBox;
        private Label recentLabel;
        private Label seeAllLabel;
        private Panel contactPanel;
        private Panel contact1Panel;
        private Label contact1NameLabel;
        private Label contact1PhoneLabel;
        private Panel contact2Panel;
        private Label contact2NameLabel;
        private Label contact2PhoneLabel;
        private Label setAmountLabel;
        private Label amountSubLabel;
        private RoundedTextBox amountTextBox;
        private RoundedButton transferButton;
        private RoundedTextBox balanceAmountLabel;
        private Label label1;
    }
}