using PaymentSystem.Models.Enums;
using PaymentSystem.Models.Interfaces;

namespace PaymentSystem.Models
{
    public class Cash : IPaymentOption
    {
        public string Description { get; } = string.Empty;
        public PaymentType PaymentType => PaymentType.Cash;
    }
}
