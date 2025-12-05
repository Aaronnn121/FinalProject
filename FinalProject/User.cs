using System;

namespace FinalProject.Models
{
    // This model is used for transaction records displayed in the DataGridView.
    public class User 
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public decimal AccountBalance { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
    }
}