using PaymentSystem.Infrastructure;
using PaymentSystem.Models;
using PaymentSystem.Models.Interfaces;

namespace PaymentSystem.Services
{
    public class PaymentService(PaymentPersist persist)
    {
        private readonly PaymentPersist _persist = persist;

        public async Task CreateNewPayment(PaymentTransaction newTransaction)
        {
           await _persist.RegisterPayment(newTransaction);
        }



    }
}
