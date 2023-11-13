using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    // DB Set - Representação de uma tabela
    // Entities do nosso Domain ao banco de dados
    public DbSet<PurchaseNotification> PurchaseNotifications { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Recipient> Recipients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PurchaseNotification>()
            .HasOne(pn => pn.Recipient)
            .WithOne(r => r.PurchaseNotification)
            .HasForeignKey<Recipient>(r => r.PurchaseNotificationId);

        

        base.OnModelCreating(modelBuilder);
    }
}