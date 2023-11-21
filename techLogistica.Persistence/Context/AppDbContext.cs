using Microsoft.EntityFrameworkCore;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseNotification>()
            .HasOne(pn => pn.Recipient)
            .WithMany()
            .HasForeignKey(pn => pn.RecipientId)
            .OnDelete(DeleteBehavior.Restrict); 
            base.OnModelCreating(modelBuilder); 
        }
    }
//modelBuilder.Entity<User>().Ignore(user => user.Perfil);
            //modelBuilder.Entity<frete>()
            //.HasOne(frete => frete.Destinatario) // quando possuir varios perfis
            //.whitOne(destinario => frete.Destinario) // associando o perfil ao usuario
            //.HasForeingnKey(Destinatario => destinario.DestinatarioID); // e o que eu to dizendo que é o N do relacionamento *-//