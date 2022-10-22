using Microsoft.EntityFrameworkCore;

namespace Platform.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Platform> Platforms { get; set; }
    }
}
