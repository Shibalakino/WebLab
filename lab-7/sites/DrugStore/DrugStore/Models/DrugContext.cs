using Microsoft.EntityFrameworkCore;

namespace DrugStore.Models
{
    public class DrugContext : DbContext
    {
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDrug> OrderDrugs { get; set; }

        public DrugContext(DbContextOptions<DrugContext> options)
        : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}