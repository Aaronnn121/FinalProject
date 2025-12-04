using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Form5
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
            successLabel = new Label();
            mainPanel = new Panel();
            orderDetailsLabel = new Label();
            receiverNoLabel = new Label();
            receiverValueLabel = new Label();
            senderNoLabel = new Label();
            senderValueLabel = new Label();
            amountLabel = new Label();
            amountValueLabel = new Label();
            dateTimeLabel = new Label();
            dateTimeValueLabel = new Label();
            newBalanceLabel = new Label();
            newBalanceValueLabel = new Label();
            recentTransactionButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            successLabel.ForeColor = Color.FromArgb(45, 52, 54);
            successLabel.Location = new Point(75, 67);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(240, 32);
            successLabel.TabIndex = 0;
            successLabel.Text = "Transfer Successful!";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(orderDetailsLabel);
            mainPanel.Controls.Add(receiverNoLabel);
            mainPanel.Controls.Add(receiverValueLabel);
            mainPanel.Controls.Add(senderNoLabel);
            mainPanel.Controls.Add(senderValueLabel);
            mainPanel.Controls.Add(amountLabel);
            mainPanel.Controls.Add(amountValueLabel);
            mainPanel.Controls.Add(dateTimeLabel);
            mainPanel.Controls.Add(dateTimeValueLabel);
            mainPanel.Controls.Add(newBalanceLabel);
            mainPanel.Controls.Add(newBalanceValueLabel);
            mainPanel.Location = new Point(20, 120);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(335, 400);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += MainPanel_Paint;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.AutoSize = true;
            orderDetailsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            orderDetailsLabel.ForeColor = Color.FromArgb(45, 52, 54);
            orderDetailsLabel.Location = new Point(30, 20);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.Size = new Size(110, 21);
            orderDetailsLabel.TabIndex = 2;
            orderDetailsLabel.Text = "Order Details";
            // 
            // receiverNoLabel
            // 
            receiverNoLabel.AutoSize = true;
            receiverNoLabel.Font = new Font("Segoe UI", 9F);
            receiverNoLabel.ForeColor = Color.FromArgb(127, 140, 141);
            receiverNoLabel.Location = new Point(30, 70);
            receiverNoLabel.Name = "receiverNoLabel";
            receiverNoLabel.Size = new Size(73, 15);
            receiverNoLabel.TabIndex = 3;
            receiverNoLabel.Text = "Receiver No.";
            // 
            // receiverValueLabel
            // 
            receiverValueLabel.AutoSize = true;
            receiverValueLabel.Font = new Font("Segoe UI", 10F);
            receiverValueLabel.ForeColor = Color.FromArgb(45, 52, 54);
            receiverValueLabel.Location = new Point(30, 90);
            receiverValueLabel.Name = "receiverValueLabel";
            receiverValueLabel.Size = new Size(97, 19);
            receiverValueLabel.TabIndex = 4;
            receiverValueLabel.Text = "09990364060";
            // 
            // senderNoLabel
            // 
            senderNoLabel.AutoSize = true;
            senderNoLabel.Font = new Font("Segoe UI", 9F);
            senderNoLabel.ForeColor = Color.FromArgb(127, 140, 141);
            senderNoLabel.Location = new Point(30, 130);
            senderNoLabel.Name = "senderNoLabel";
            senderNoLabel.Size = new Size(65, 15);
            senderNoLabel.TabIndex = 5;
            senderNoLabel.Text = "Sender No.";
            // 
            // senderValueLabel
            // 
            senderValueLabel.AutoSize = true;
            senderValueLabel.Font = new Font("Segoe UI", 10F);
            senderValueLabel.ForeColor = Color.FromArgb(45, 52, 54);
            senderValueLabel.Location = new Point(30, 150);
            senderValueLabel.Name = "senderValueLabel";
            senderValueLabel.Size = new Size(97, 19);
            senderValueLabel.TabIndex = 6;
            senderValueLabel.Text = "09572887390";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9F);
            amountLabel.ForeColor = Color.FromArgb(127, 140, 141);
            amountLabel.Location = new Point(30, 190);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(51, 15);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount";
            // 
            // amountValueLabel
            // 
            amountValueLabel.AutoSize = true;
            amountValueLabel.Font = new Font("Segoe UI", 10F);
            amountValueLabel.ForeColor = Color.FromArgb(45, 52, 54);
            amountValueLabel.Location = new Point(30, 210);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(52, 19);
            amountValueLabel.TabIndex = 8;
            amountValueLabel.Text = "₱5,000";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 9F);
            dateTimeLabel.ForeColor = Color.FromArgb(127, 140, 141);
            dateTimeLabel.Location = new Point(30, 250);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(64, 15);
            dateTimeLabel.TabIndex = 9;
            dateTimeLabel.Text = "Date & Time";
            // 
            // dateTimeValueLabel
            // 
            dateTimeValueLabel.AutoSize = true;
            dateTimeValueLabel.Font = new Font("Segoe UI", 10F);
            dateTimeValueLabel.ForeColor = Color.FromArgb(45, 52, 54);
            dateTimeValueLabel.Location = new Point(30, 270);
            dateTimeValueLabel.Name = "dateTimeValueLabel";
            dateTimeValueLabel.Size = new Size(148, 19);
            dateTimeValueLabel.TabIndex = 10;
            dateTimeValueLabel.Text = "Dec 4, 2023 10:30 AM";
            // 
            // newBalanceLabel
            // 
            newBalanceLabel.AutoSize = true;
            newBalanceLabel.Font = new Font("Segoe UI", 9F);
            newBalanceLabel.ForeColor = Color.FromArgb(127, 140, 141);
            newBalanceLabel.Location = new Point(30, 310);
            newBalanceLabel.Name = "newBalanceLabel";
            newBalanceLabel.Size = new Size(75, 15);
            newBalanceLabel.TabIndex = 11;
            newBalanceLabel.Text = "New Balance";
            // 
            // newBalanceValueLabel
            // 
            newBalanceValueLabel.AutoSize = true;
            newBalanceValueLabel.Font = new Font("Segoe UI", 10F);
            newBalanceValueLabel.ForeColor = Color.FromArgb(45, 52, 54);
            newBalanceValueLabel.Location = new Point(30, 330);
            newBalanceValueLabel.Name = "newBalanceValueLabel";
            newBalanceValueLabel.Size = new Size(87, 19);
            newBalanceValueLabel.TabIndex = 12;
            newBalanceValueLabel.Text = "₱12,495,000";
            // 
            // recentTransactionButton
            // 
            recentTransactionButton.BackColor = Color.FromArgb(45, 52, 54);
            recentTransactionButton.FlatStyle = FlatStyle.Flat;
            recentTransactionButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            recentTransactionButton.ForeColor = Color.White;
            recentTransactionButton.Location = new Point(50, 540);
            recentTransactionButton.Name = "recentTransactionButton";
            recentTransactionButton.Size = new Size(275, 50);
            recentTransactionButton.TabIndex = 13;
            recentTransactionButton.Text = "Go to Recent Transaction";
            recentTransactionButton.UseVisualStyleBackColor = false;
            recentTransactionButton.Paint += Button_Paint;
            // 
            // Form5
            // 
            BackColor = Color.FromArgb(226, 240, 203);
            ClientSize = new Size(375, 667);
            Controls.Add(successLabel);
            Controls.Add(mainPanel);
            Controls.Add(recentTransactionButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer Successful";
            Load += Form5_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label successLabel;
        private Panel mainPanel;
        private Label orderDetailsLabel;
        private Label receiverNoLabel;
        private Label receiverValueLabel;
        private Label senderNoLabel;
        private Label senderValueLabel;
        private Label amountLabel;
        private Label amountValueLabel;
        private Label dateTimeLabel;
        private Label dateTimeValueLabel;
        private Label newBalanceLabel;
        private Label newBalanceValueLabel;
        private Button recentTransactionButton;

        // Custom paint methods for rounded appearance
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded rectangle background
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
                using (GraphicsPath path = GetRoundedRectPath(rect, 15))
                {
                    panel.Region = new Region(path);
                    using (SolidBrush brush = new SolidBrush(panel.BackColor))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded rectangle background
                Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
                using (GraphicsPath path = GetRoundedRectPath(rect, 8))
                {
                    button.Region = new Region(path);
                    using (SolidBrush brush = new SolidBrush(button.BackColor))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);
            // Top right corner
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            // Bottom right corner
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // Bottom left corner
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}