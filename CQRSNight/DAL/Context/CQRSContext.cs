using CQRSNight.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.DAL.Context
{
    public class CQRSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E4NV9FV;initial Catalog=CQRSDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
