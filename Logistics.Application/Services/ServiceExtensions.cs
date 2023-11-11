/*Iusing MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;

public static class ServiceExtensions
{
    public static void ConfigureApplicationApp(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        // Adicione a configuração do FluentValidation aqui se necessário
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    }
}
*/