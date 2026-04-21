using AbmPersonas.Application.Interfaces;
using AbmPersonas.Application.Services;
using AbmPersonas.Domain.Interfaces;
using AbmPersonas.Infrastructure.Data;
using AbmPersonas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AbmPersonas.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPersonaService, PersonaService>();
        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer")
            ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SqlServer'.");

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IPersonaRepository, PersonaRepository>();
        return services;
    }
}
