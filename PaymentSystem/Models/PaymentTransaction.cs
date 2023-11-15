using PaymentSystem.Models.Enums;

namespace PaymentSystem.Models
{
    public class PaymentTransaction(int customerId, string description, int orderNumber, PaymentType paymentType, double amount)
    {
        public int Id { get; init; }
        public int CustomerId { get; init; } = customerId;
        public int OrderNumber { get; init; } = orderNumber;
        public string Description { get; init; } = description;
        public PaymentType PaymentType { get; init; } = paymentType;
        public double Amount { get; init; } = amount;
        public DateTime TransactionTime { get; init; } = DateTime.UtcNow;
       
    }
}
