using FurnitureStore.Infrastructure.Table;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Infrastructure
{
    public class StoreContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
