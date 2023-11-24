using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using techLogistica.Domain.Entities;



    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // DB Set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados
        public DbSet<PurchaseNotification> PurchaseNotifications { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<DeliveryMan> DeliveryMen { get; set; }

        


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<PurchaseNotification>()
       .Property(r => r.RecipientId)
       .HasDefaultValue(null);

        modelBuilder.Entity<PurchaseNotification>()
            .Property(r => r.ProductId)
            .HasDefaultValue(null);

        /*modelBuilder.Entity<MaterialSupplier>()
           .HasKey(ms => new { ms.SupplierId, ms.MaterialId }); */

        /* modelBuilder.Entity<MaterialProduct>()
            .HasKey(mp => new { mp.ProductId, mp.MaterialId }); */

        /* modelBuilder.Entity<Order>()
            .HasOne(r => r.Supplier)
            .WithMany(s => s.Orders)
            .HasForeignKey(r => r.SupplierId)
            .OnDelete(DeleteBehavior.Cascade); */

        /* modelBuilder.Entity<Order>()
            .HasOne(r => r.Product)
            .WithMany(p => p.Orders)
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade); */

        /* modelBuilder.Entity<Order>()
           .HasOne(r => r.Contract)
           .WithMany(p => p.Orders)
           .HasForeignKey(r => r.ContractId)
           .OnDelete(DeleteBehavior.Cascade); */

        /* modelBuilder.Entity<Contract>()
           .HasOne(c => c.Supplier)
           .WithMany(s => s.Contracts)
           .HasForeignKey(c => c.SupplierId)
           .OnDelete(DeleteBehavior.Cascade); */

        /* modelBuilder.Entity<Payment>()
           .HasOne(p => p.Order)
           .WithMany(c => c.Payments)
           .HasForeignKey(p => p.OrderId)
           .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder); */
    }
    }


//modelBuilder.Entity<User>().Ignore(user => user.Perfil);
//modelBuilder.Entity<frete>()
//.HasOne(frete => frete.Destinatario) // quando possuir varios perfis
//.whitOne(destinario => frete.Destinario) // associando o perfil ao usuario
//.HasForeingnKey(Destinatario => destinario.DestinatarioID); // e o que eu to dizendo que é o N do relacionamento *-//