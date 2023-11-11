using Logistics.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    // Representação de tabelas no banco de dados
    public DbSet<Receiver> Receivers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Policy> Policies { get; set; }
    public DbSet<PurchaseNotification> PurchaseNotifications { get; set; }

    // Configurações adicionais podem ser definidas no método OnModelCreating se necessário
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurações adicionais, como relações entre entidades, índices, etc.
        base.OnModelCreating(modelBuilder);
    }
}

