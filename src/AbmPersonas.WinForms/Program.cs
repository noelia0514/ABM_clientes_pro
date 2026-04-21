using AbmPersonas.Application.Interfaces;
using AbmPersonas.Application.Services;
using AbmPersonas.Domain.Interfaces;
using AbmPersonas.Infrastructure.Data;
using AbmPersonas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AbmPersonas.WinForms;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        ConfigureServices(services);

        using var provider = services.BuildServiceProvider();
        using var scope = provider.CreateScope();
        var mainForm = scope.ServiceProvider.GetRequiredService<Form1>();
        System.Windows.Forms.Application.Run(mainForm);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .Build();

        var connectionString = configuration.GetConnectionString("SqlServer")
            ?? throw new InvalidOperationException("No se encontro ConnectionStrings:SqlServer.");

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IPersonaRepository, PersonaRepository>();
        services.AddScoped<IPersonaService, PersonaService>();
        services.AddScoped<Form1>();
    }
}