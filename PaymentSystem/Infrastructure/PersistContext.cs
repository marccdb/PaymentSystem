using Microsoft.EntityFrameworkCore;
using PaymentSystem.Models;

namespace PaymentSystem.Infrastructure
{
    public class PersistContext(DbContextOptions<PersistContext> options) : DbContext(options)
    {
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
    }
}
