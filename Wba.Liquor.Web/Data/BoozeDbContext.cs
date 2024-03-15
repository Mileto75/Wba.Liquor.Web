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
            base.OnModelCreating(modelBuilder);
        }
    }
}
