using Microsoft.EntityFrameworkCore;

namespace PhotoArchive.Models
{
    public class PhotoArchiveContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Author> Authors { get; set; }

        public PhotoArchiveContext(DbContextOptions<PhotoArchiveContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
