using Datos.Contexts;
using Datos.Repositories;
using Datos.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Negocio.Contracts;
using Negocio.Implementations;

namespace Presentacion
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            _serviceProvider = host.Services;

            Application.Run(_serviceProvider.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddTransient<IClienteLogic, ClienteLogic>();
                    services.AddTransient<ICuentaBancariaLogic, CuentaBancariaLogic>();
                    services.AddTransient<ITarjetaCreditoLogic, TarjetaCreditoLogic>();


                    services.AddTransient<IClienteRepository, ClienteRepository>();
                    services.AddTransient<ICuentaBancariaRepository, CuentaBancariaRepository>();
                    services.AddTransient<ITarjetaCreditoRepository, TarjetaCreditoRepository>();

                    services.AddTransient<Form1>();

                    services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AppBancaria;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Scoped);
                });
        }
    }
}