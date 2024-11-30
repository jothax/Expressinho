using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Car>().Property(x => x.Id);
            modelBuilder.Entity<Car>().Property(x => x.Model);
            modelBuilder.Entity<Car>().Property(x => x.Year).HasColumnType("varchar(4)");
            modelBuilder.Entity<Car>().Property(x => x.Plate).HasColumnType("varchar(7)");
            modelBuilder.Entity<Car>().Property(x => x.IdMotorist);
            modelBuilder.Entity<Car>().HasIndex(b => b.Id);
            modelBuilder.Entity<Car>().HasIndex(b => b.IdMotorist);
        }
    }
}