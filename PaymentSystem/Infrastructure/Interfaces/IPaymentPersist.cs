using PaymentSystem.Models;

namespace PaymentSystem.Infrastructure.Interfaces
{
    public interface IPaymentPersist
    {
        Task RegisterPayment(PaymentTransaction newTransation);
        Task SaveChangesAsync();
    }
}
