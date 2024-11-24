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
        public DbSet<Country> Countries { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Payment> Payments { get; set; }

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

            modelBuilder.Entity<Ticket>()
           .HasOne(t => t.Tour)
           .WithMany(d => d.Tickets) // A tour can have many tickets
           .HasForeignKey(t => t.TourId)
           .OnDelete(DeleteBehavior.Cascade); // Cascade deletion when a tour is deleted

            // Configuration for Ticket and User
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tickets) // A user can have many tickets
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of user if tickets exist

            // Configuration for Ticket and Payment
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Payment)
                .WithMany(p => p.Tickets) // A payment can relate to many tickets
                .HasForeignKey(t => t.PaymentId)
                .OnDelete(DeleteBehavior.SetNull); // Set PaymentId to null if payment is deleted

            // Optional: Configuration for Payment entity
            modelBuilder.Entity<Payment>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Payment)
                .HasForeignKey(t => t.PaymentId);

            // Ensure required properties have constraints (Optional)
            modelBuilder.Entity<Payment>()
                .Property(p => p.TransactionId)
                .IsRequired();

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2); // Ensure precision for decimal values
        }
    }
}
