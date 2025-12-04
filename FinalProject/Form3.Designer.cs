using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Form3
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
            mainPanel = new Panel();
            balanceLabel = new Label();
            greetingLabel = new Label();
            userNameLabel = new Label();
            accountBalanceLabel = new Label();
            balanceAmountLabel = new Label();
            addMoneyButton = new RoundedButton();
            fundTransferButton = new RoundedButton();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(45, 52, 54);
            mainPanel.Controls.Add(balanceLabel);
            mainPanel.Controls.Add(greetingLabel);
            mainPanel.Controls.Add(userNameLabel);
            mainPanel.Controls.Add(accountBalanceLabel);
            mainPanel.Controls.Add(balanceAmountLabel);
            mainPanel.Controls.Add(addMoneyButton);
            mainPanel.Controls.Add(fundTransferButton);
            mainPanel.Location = new Point(20, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(288, 483);
            mainPanel.TabIndex = 0;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            balanceLabel.ForeColor = Color.White;
            balanceLabel.Location = new Point(30, 151);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(129, 30);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "12,500,000";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 12F);
            greetingLabel.ForeColor = Color.White;
            greetingLabel.Location = new Point(30, 30);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(84, 21);
            greetingLabel.TabIndex = 1;
            greetingLabel.Text = "Good Day!";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(30, 62);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(247, 30);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Mark Aaron Estanooco";
            userNameLabel.Click += userNameLabel_Click;
            // 
            // accountBalanceLabel
            // 
            accountBalanceLabel.AutoSize = true;
            accountBalanceLabel.Font = new Font("Segoe UI", 10F);
            accountBalanceLabel.ForeColor = Color.FromArgb(189, 195, 199);
            accountBalanceLabel.Location = new Point(30, 120);
            accountBalanceLabel.Name = "accountBalanceLabel";
            accountBalanceLabel.Size = new Size(109, 19);
            accountBalanceLabel.TabIndex = 3;
            accountBalanceLabel.Text = "Account Balance";
            // 
            // balanceAmountLabel
            // 
            balanceAmountLabel.AutoSize = true;
            balanceAmountLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            balanceAmountLabel.ForeColor = Color.White;
            balanceAmountLabel.Location = new Point(30, 145);
            balanceAmountLabel.Name = "balanceAmountLabel";
            balanceAmountLabel.Size = new Size(0, 37);
            balanceAmountLabel.TabIndex = 4;
            // 
            // addMoneyButton
            // 
            addMoneyButton.BackColor = Color.FromArgb(0, 188, 212);
            addMoneyButton.CornerRadius = 20;
            addMoneyButton.FlatStyle = FlatStyle.Flat;
            addMoneyButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addMoneyButton.ForeColor = Color.White;
            addMoneyButton.Location = new Point(26, 409);
            addMoneyButton.Name = "addMoneyButton";
            addMoneyButton.Size = new Size(110, 40);
            addMoneyButton.TabIndex = 5;
            addMoneyButton.Text = "Add Money";
            addMoneyButton.UseVisualStyleBackColor = false;
            // 
            // fundTransferButton
            // 
            fundTransferButton.BackColor = Color.FromArgb(0, 188, 212);
            fundTransferButton.CornerRadius = 20;
            fundTransferButton.FlatStyle = FlatStyle.Flat;
            fundTransferButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fundTransferButton.ForeColor = Color.White;
            fundTransferButton.Location = new Point(157, 409);
            fundTransferButton.Name = "fundTransferButton";
            fundTransferButton.Size = new Size(110, 40);
            fundTransferButton.TabIndex = 6;
            fundTransferButton.Text = "Fund Transfer";
            fundTransferButton.UseVisualStyleBackColor = false;
            fundTransferButton.Click += fundTransferButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 240, 203);
            ClientSize = new Size(328, 580);
            Controls.Add(mainPanel);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEEBank";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label greetingLabel;
        private Label userNameLabel;
        private Label accountBalanceLabel;
        private Label balanceAmountLabel;
        private RoundedButton addMoneyButton;
        private RoundedButton fundTransferButton;
        private Label balanceLabel;
    }
}