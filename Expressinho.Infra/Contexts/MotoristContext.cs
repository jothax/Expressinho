using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class MotoristContext : DbContext
    {
        public MotoristContext(DbContextOptions<MotoristContext> options) : base(options)
        {
        }

        public DbSet<Motorist> Motorists { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motorist>().ToTable("Motorist");
            modelBuilder.Entity<Motorist>().Property(x => x.Id);
            modelBuilder.Entity<Motorist>().Property(x => x.Name).HasColumnType("varchar(120)");
            modelBuilder.Entity<Motorist>().Property(x => x.Email).HasColumnType("varchar(160)");
            modelBuilder.Entity<Motorist>().Property(x => x.BirthDate);
            modelBuilder.Entity<Motorist>().Property(x => x.Licence);
            modelBuilder.Entity<Motorist>().Property(x => x.LicenceCategory);
            modelBuilder.Entity<Motorist>().Property(x => x.Password);
            modelBuilder.Entity<Motorist>().Property(x => x.Salt);
            modelBuilder.Entity<Motorist>().Property(x => x.Iterations);
            modelBuilder.Entity<Motorist>().Property(x => x.Active);
            modelBuilder.Entity<Motorist>().HasIndex(b => b.Id);
            modelBuilder.Entity<Motorist>().HasIndex(b => b.Email);
        }
    }
}