using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using techLogistica.Domain.Interfaces;

namespace techLogistica.Persistence.Repositories
{

    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(
            this IServiceCollection service, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Dbconnect");

            service.AddDbContext<AppDbContext>(
                opt => opt.UseSqlite(connectionString));

            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<IPurchaseNotificationRepository, PurchaseNotificationRepository>();
            service.AddScoped<IDeliveryRepository, DeliveryRepository>();
            service.AddScoped<DeliveryPersonRepository, DeliveryPersonRepository>();
            service.AddScoped<IShippingRepository, ShippingRepository>();
            service.AddScoped<IKafkaProducer, KafkaProducer>();
            service.AddScoped<IKafkaConsumer, KafkaConsumer>();
            service.AddScoped<IRedisRepository, RedisRepository>();
        }
    }

}