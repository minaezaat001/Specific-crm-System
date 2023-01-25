using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<Order> Orders   { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Login> Logins { get; set; }


    }
}
