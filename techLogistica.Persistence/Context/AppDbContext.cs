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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento entre PurchaseNotification e Recipient
            modelBuilder.Entity<Recipient>()
                .HasMany(r => r.PurchaseNotifications)
                .WithOne(pn => pn.Recipient)
                .HasForeignKey(pn => pn.RecipientId);

            // Relacionamento entre PurchaseNotification e PurchasedProduct
            modelBuilder.Entity<Product>()
                .HasOne(pp => pp.PurchaseNotification)
                .WithMany(pn => pn.Products)
                .HasForeignKey(pp => pp.PurchaseNotificationId);

            base.OnModelCreating(modelBuilder);
        }

         
        
    }
    


//modelBuilder.Entity<User>().Ignore(user => user.Perfil);
//modelBuilder.Entity<frete>()
//.HasOne(frete => frete.Destinatario) // quando possuir varios perfis
//.whitOne(destinario => frete.Destinario) // associando o perfil ao usuario
//.HasForeingnKey(Destinatario => destinario.DestinatarioID); // e o que eu to dizendo que é o N do relacionamento *-//