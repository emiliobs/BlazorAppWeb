using BlazorProvider.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorProvider.Data
{
    public class AppDbContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; }
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable($"App{nameof(Users)}");
            modelBuilder.Entity<User>(entity => { entity.HasIndex(t => t.Email).IsUnique(); });
        }

    }
}
