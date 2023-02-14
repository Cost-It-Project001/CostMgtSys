using CostItArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CostItArchitecture.Infrastructure.Context
{
    public class CostItDbcontext : DbContext, ICostItDbcontext
    {
        public CostItDbcontext(DbContextOptions<CostItDbcontext>
            options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<Estimate>(e => e.Estimate)
                .WithMany(e => e.Users)
                .HasForeignKey(e => e.EstimateId);
            modelBuilder.Entity<Estimate>()
                .HasOne<Customer>(c => c.Customers)
                .WithMany(c => c.Estimates)
                .HasForeignKey(c => c.CustomerId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }

    }
}
