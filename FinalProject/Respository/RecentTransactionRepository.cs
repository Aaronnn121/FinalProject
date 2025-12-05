using System.Collections.Generic;
using System.Linq; // Required for .Max()
using FinalProject.Models;
using System; // Required for DateTime

namespace FinalProject
{
    public class RecentTransactionRepository
    {
        // CRITICAL FIX: Use a static list to hold all transactions in memory.
        private static List<User> _transactions;

        public RecentTransactionRepository()
        {
            // Initialize the list only once when the first repository instance is created.
            if (_transactions == null)
            {
                // Initialize with some mock data for display on first load
                _transactions = new List<User>
                {
                    new User { Id = 1, FullName = "Alice Smith", AccountBalance = 1250.75m, TransactionDate = DateTime.Now.AddHours(-3), TransactionType = "Deposit", Amount = 500.00m },
                    new User { Id = 2, FullName = "Bob Johnson", AccountBalance = 900.20m, TransactionDate = DateTime.Now.AddDays(-1), TransactionType = "Transfer", Amount = 150.00m },
                    new User { Id = 3, FullName = "Charlie Day", AccountBalance = 350.50m, TransactionDate = DateTime.Now.AddDays(-2), TransactionType = "Withdrawal", Amount = 50.00m }
                };
            }
        }

        /// <summary>
        /// Retrieves the current list of transactions from memory.
        /// </summary>
        public List<User> GetAll()
        {
            return _transactions;
        }

        /// <summary>
        /// Saves a new transaction to the in-memory list.
        /// </summary>
        /// <param name="newTransaction">The transaction model to save.</param>
        public void SaveTransaction(User newTransaction)
        {
            // Set a basic ID for the new item
            int newId = _transactions.Count > 0 ? _transactions.Max(u => u.Id) + 1 : 1;
            newTransaction.Id = newId;

            // Ensure the transaction date is set when saving
            newTransaction.TransactionDate = DateTime.Now;

            // Add the new transaction to the static list
            _transactions.Add(newTransaction);
        }
    }
}