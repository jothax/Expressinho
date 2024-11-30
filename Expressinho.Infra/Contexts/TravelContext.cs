using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {
        }

        public DbSet<Travel> Travels { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Travel>().ToTable("Travel");
            modelBuilder.Entity<Travel>().Property(x => x.Id);
            modelBuilder.Entity<Travel>().Property(x => x.Origin).HasColumnType("varchar(120)");
            modelBuilder.Entity<Travel>().Property(x => x.Destiny).HasColumnType("varchar(120)");
            modelBuilder.Entity<Travel>().Property(x => x.Price);
            modelBuilder.Entity<Travel>().Property(x => x.PaymentMethod);
            modelBuilder.Entity<Travel>().Property(x => x.TripMethod);
            modelBuilder.Entity<Travel>().Property(x => x.StartDate);
            modelBuilder.Entity<Travel>().Property(x => x.FinishDate);
            modelBuilder.Entity<Travel>().Property(x => x.IdPassager);
            modelBuilder.Entity<Travel>().Property(x => x.IdMotorist);
            modelBuilder.Entity<Travel>().HasIndex(b => b.Id);
        }
    }
}