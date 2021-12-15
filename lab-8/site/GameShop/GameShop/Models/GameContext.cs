using Microsoft.EntityFrameworkCore;

namespace GameShop.Models
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

    }
}