using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class PassagerContext : DbContext
    {
        public PassagerContext(DbContextOptions<PassagerContext> options) : base(options)
        {
        }

        public DbSet<Passager> Passagers { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passager>().ToTable("Passager");
            modelBuilder.Entity<Passager>().Property(x => x.Id);
            modelBuilder.Entity<Passager>().Property(x => x.Name).HasColumnType("varchar(120)");
            modelBuilder.Entity<Passager>().Property(x => x.Email).HasColumnType("varchar(160)");
            modelBuilder.Entity<Passager>().Property(x => x.BirthDate);
            modelBuilder.Entity<Passager>().Property(x => x.Password);
            modelBuilder.Entity<Passager>().Property(x => x.Salt);
            modelBuilder.Entity<Passager>().Property(x => x.Iterations);
            modelBuilder.Entity<Passager>().Property(x => x.Active);
            modelBuilder.Entity<Passager>().HasIndex(b => b.Id);
            modelBuilder.Entity<Passager>().HasIndex(b => b.Email);
        }
    }
}