using PaymentSystem.Models.Enums;
using PaymentSystem.Models.Interfaces;

namespace PaymentSystem.Models
{
    public class CreditCard(string cardOwner, decimal cardNumber, DateOnly cardExpiryDate, int cardSecurityCode, CreditCardProvider creditCardProvider) : IPaymentOption
    {
        private int Id { get; }
        public string Description { get; }
        private string CardOwner { get; } = cardOwner;
        private decimal CardNumber { get; } = cardNumber;
        private DateOnly CardExpiryDate { get; } = cardExpiryDate;
        private int CardSecurityCode { get; } = cardSecurityCode;
        private CreditCardProvider CreditCardProvider { get; } = creditCardProvider;
        PaymentType IPaymentOption.PaymentType => PaymentType.CrediCard;
    }
        

}