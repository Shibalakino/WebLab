using Microsoft.EntityFrameworkCore;

namespace ComputerStore.Models
{
    public class ComputerContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderComputer> OrderComputers { get; set; }

        public ComputerContext(DbContextOptions<ComputerContext> options)
        : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}