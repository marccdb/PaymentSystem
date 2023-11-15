using PaymentSystem.Models;

namespace PaymentSystem.Services.Interfaces
{
    public interface IPaymentService
    {
        Task CreateNewPayment(PaymentTransaction newTransaction);
    }
}
