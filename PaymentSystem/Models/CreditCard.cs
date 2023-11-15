using PaymentSystem.Models.Enums;

namespace PaymentSystem.Models
{
    public class CreditCard(int customerId, string description, string cardOwner, decimal cardNumber, DateOnly cardExpiryDate, CreditCardProvider creditCardProvider)
    {
        public int Id { get; init; }
        public int CustomerId { get; init; } = customerId;
        public string Description { get; init; } = description;
        public string CardOwner { get; init; } = cardOwner;
        public decimal CardNumber { get; init; } = cardNumber;
        public DateOnly CardExpiryDate { get; init; } = cardExpiryDate;
        public CreditCardProvider CreditCardProvider { get; init; } = creditCardProvider;
    }
        

}