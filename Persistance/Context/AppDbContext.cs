    using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TourGuide.Domain.Entities;
using TourGuide.Persistance.Configurations;

namespace TourGuide.Persistance.Context
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<DestinationAddress> DestinationAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply configurations for Category and Destination
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DestinationConfiguration());

            modelBuilder.Entity<DestinationAddress>()
            .HasKey(da => new { da.DestinationId, da.AddressId });

            modelBuilder.Entity<DestinationAddress>()
                .HasOne(da => da.Destination)
                .WithMany() 
                .HasForeignKey(da => da.DestinationId);

            modelBuilder.Entity<DestinationAddress>()
                .HasOne(da => da.Address)
                .WithMany() 
                .HasForeignKey(da => da.AddressId);
        }
    }
}
