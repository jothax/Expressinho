using Expressinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expressinho.Infra.Contexts
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Address>().Property(x => x.Id);
            modelBuilder.Entity<Address>().Property(x => x.Street).HasColumnType("varchar(120)");
            modelBuilder.Entity<Address>().Property(x => x.Number).HasColumnType("varchar(100)");
            modelBuilder.Entity<Address>().Property(x => x.City).HasColumnType("varchar(100)");
            modelBuilder.Entity<Address>().Property(x => x.State).HasColumnType("varchar(2)");
            modelBuilder.Entity<Address>().Property(x => x.Zipcode).HasColumnType("varchar(10)");
            modelBuilder.Entity<Address>().Property(x => x.IdEntity);
            modelBuilder.Entity<Address>().HasIndex(b => b.Id);
            modelBuilder.Entity<Address>().HasIndex(b => b.IdEntity);
        }
    }
}