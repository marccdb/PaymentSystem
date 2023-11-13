using PaymentSystem.Models.Enums;

namespace PaymentSystem.Models
{
    public class PaymentTransaction(string description, int orderNumber, PaymentType paymentType, double amount)
    {
        public int Id { get; }
        public int OrderNumber { get; } = orderNumber;
        public string Description { get; } = description;
        public PaymentType PaymentType { get; } = paymentType;
        public double Amount { get; } = amount;
        public CreditCard? CreditCardId { get; }



        public DateTime TransactionTime { get; } = DateTime.UtcNow;
       
    }
}
