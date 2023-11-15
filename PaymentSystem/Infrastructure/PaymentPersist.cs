using PaymentSystem.Infrastructure.Interfaces;
using PaymentSystem.Models;

namespace PaymentSystem.Infrastructure
{
    public class PaymentPersist(PersistContext context) : IPaymentPersist
    {

        private readonly PersistContext _context = context;

        public async Task RegisterPayment(PaymentTransaction newTransaction)
        {
            await _context.PaymentTransactions.AddAsync(newTransaction);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
