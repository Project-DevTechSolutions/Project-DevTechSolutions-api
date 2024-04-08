using Dev.Tech.Solutions.Domain.Catalog;
using Microsoft.EntityFrameworkCore;


namespace Dev.Tech.Solutions.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
              new Item("Shirt", "Ohio State Shirt", "Nike", 29.99M)
              {
                Id=1
              },
              new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
              {
                Id = 2
              } 
            );
        }
    }
}