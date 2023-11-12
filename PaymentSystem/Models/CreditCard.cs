using PaymentSystem.Models.Enums;
using PaymentSystem.Models.Interfaces;

namespace PaymentSystem.Models
{
    public class CreditCard(string cardOwner, decimal cardNumber, DateOnly cardExpiryDate, int cardSecurityCode, CreditCardProvider creditCardProvider) : IPaymentOption
    {
        public int Id { get; }
        public string Description { get; } = string.Empty;
        public string CardOwner { get; } = cardOwner;
        public decimal CardNumber { get; } = cardNumber;
        public DateOnly CardExpiryDate { get; } = cardExpiryDate;
        public int CardSecurityCode { get; } = cardSecurityCode;
        public CreditCardProvider CreditCardProvider { get; } = creditCardProvider;
        PaymentType IPaymentOption.PaymentType => PaymentType.CrediCard;
    }
        

}