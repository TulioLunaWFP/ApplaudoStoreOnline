using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplaudoStore.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Custumers { get; set; }
        public DbSet<Login> Logins { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)  { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-STSDSKH\SQLEXPRESS;Initial Catalog=applaudostore;Integrated Security=True");
        }
    }
}
