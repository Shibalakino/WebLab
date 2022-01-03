using Microsoft.EntityFrameworkCore;
using GameShop.Models;
using GameShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GameShop.Data
{
    public class GameContext : IdentityDbContext<GameShopUser>
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameShopUser> GameShopUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}