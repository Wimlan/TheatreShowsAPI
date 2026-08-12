using Microsoft.EntityFrameworkCore;
using TheatreShowsAPI.Models;

namespace TheatreShowsAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Show> Shows => Set<Show>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<ProductionMember> ProductionMembers => Set<ProductionMember>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>()
                .HasMany(s => s.Genres)
                .WithMany(g => g.Shows)
                .UsingEntity(j => j.ToTable("shows_genres"));

            modelBuilder.Entity<Show>()
       .HasMany(s => s.ProductionMembers)
       .WithMany(p => p.Shows)
       .UsingEntity(j => j.ToTable("shows_productionmembers"));
        }

    }
}
