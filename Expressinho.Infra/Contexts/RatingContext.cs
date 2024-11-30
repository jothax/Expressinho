using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class RatingContext : DbContext
    {
        public RatingContext(DbContextOptions<RatingContext> options) : base(options)
        {
        }

        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<Rating>().Property(x => x.Id);
            modelBuilder.Entity<Rating>().Property(x => x.Rate);
            modelBuilder.Entity<Rating>().Property(x => x.Date);
            modelBuilder.Entity<Rating>().Property(x => x.IdEntity);
            modelBuilder.Entity<Rating>().HasIndex(b => b.Id);
            modelBuilder.Entity<Rating>().HasIndex(b => b.IdEntity);
        }
    }
}