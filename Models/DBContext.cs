using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cafe_try_two.Models
{
    public class DBContext:IdentityDbContext
    {
        public DBContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Customers>Customers { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Feedback> Feedback{ get; set; }
        public DbSet<Bill> Bill { get; set; }
    }
}
