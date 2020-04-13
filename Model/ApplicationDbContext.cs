using Microsoft.EntityFrameworkCore;

namespace WebAppPractice.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) :base(option)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}