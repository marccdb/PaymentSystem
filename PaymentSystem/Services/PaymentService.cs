using PaymentSystem.Infrastructure.Interfaces;
using PaymentSystem.Models;
using PaymentSystem.Services.Interfaces;

namespace PaymentSystem.Services
{
    public class PaymentService(IPaymentPersist persist) : IPaymentService
    {
        private readonly IPaymentPersist _persist = persist;

        public async Task CreateNewPayment(PaymentTransaction newTransaction)
        {
            await _persist.RegisterPayment(newTransaction);
            await _persist.SaveChangesAsync();
        }



    }
}
