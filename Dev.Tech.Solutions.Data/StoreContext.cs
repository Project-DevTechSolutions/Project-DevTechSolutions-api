using System.Net;
using System.Security.Cryptography.X509Certificates;
using Dev.Tech.Solutions.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Dev.Tech.Solutions.Domain.Orders;

namespace Dev.Tech.Solutions.Data{
    public class StoreContext : DbContext{
        public StoreContext(DbContextOptions<StoreContext> options): base(options){ }
        public DbSet<Item> Items {get; set;}

        public DbSet<Order> Orders {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}

