using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using techLogistica.Domain.Entities;


namespace techLogistica.Persistence.Context

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PurchaseNotification> PurchaseNotifications { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<PurchaseNotification>()
                .HasOne(n => n.Delivery)
                .WithOne(d => d.PurchaseNotification)
                .HasForeignKey<Delivery>(d => d.PurchaseNotificationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Shipping)
                .WithOne(s => s.Delivery)
                .HasForeignKey<Shipping>(s => s.DeliveryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.DeliveryPerson)
                .WithMany(dp => dp.Deliveries)
                .HasForeignKey(d => d.DeliveryPersonId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }

}