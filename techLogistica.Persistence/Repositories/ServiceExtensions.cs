using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using techLogistica.Domain.Interfaces;

// Define um método de extensão


    public static class ServiceExtensions
    {
        // Usado para configurar a camada de persistencia no EF Core
        public static void ConfigurePersistenceApp(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // usado para recuperar a string de conexão no presentation
            var connectionString = configuration.GetConnectionString("Dbconnect");

            // Definindo o provedor 
            services.AddDbContext<AppDbContext>(options => options
            .UseSqlite(connectionString));

            // Adicionando escopos de instancias unica criado e compartilhado
            // no mesmo escopo http que utilizar
            // para cada transação teremos um escopo delesva
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPurchaseNotificationRepository, PurchaseNotificationRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();



        }
    }

