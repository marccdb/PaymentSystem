using Microsoft.EntityFrameworkCore;
using PaymentSystem.Models;

namespace PaymentSystem.Infrastructure
{
    public class PaymentContext : DbContext
    {

        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }


        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }


    }
}
