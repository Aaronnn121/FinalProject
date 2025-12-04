namespace FinalProject.Models
{
    public class TransactionModel
    {
        public AccountModel Sender { get; set; }
        public AccountModel Receiver { get; set; }
        public double Amount { get; set; }
        public DateTime TrasactionDate { get; set; }
    }
}
