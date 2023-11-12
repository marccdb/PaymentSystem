using PaymentSystem.Models.Enums;

namespace PaymentSystem.Models.Interfaces
{
    public interface IPaymentOption
    {
        string Description { get; }
        PaymentType PaymentType { get; }

    }
}
