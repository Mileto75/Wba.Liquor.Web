using Microsoft.EntityFrameworkCore;
using Wba.Liquor.Core.Entities;

namespace Wba.Liquor.Web.Data
{
    public class BoozeDbContext : DbContext
    {
        //Define DbSets = tables in database
        public DbSet<Booze> Boozes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Property> Properties { get; set; }
        public BoozeDbContext(DbContextOptions<BoozeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent api configuration = alternative to data annotations

            modelBuilder.Entity<Booze>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Booze>()
                .Property(p => p.Price)
                .HasColumnType("money");
            modelBuilder.Entity<Brand>()
                .Property(b => b.Name)
                .IsRequired();
            modelBuilder.Entity<Category>()
                .Property(b => b.Name)
                .IsRequired();
            modelBuilder.Entity<Property>()
                .Property(b => b.Name)
                .IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
