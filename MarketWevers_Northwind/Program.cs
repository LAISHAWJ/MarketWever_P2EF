using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MarketWevers_Northwind
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }
        [STAThread]
        static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build(); ;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<FrmStart>();
            serviceCollection.AddTransient<FrmMenu>();
            serviceCollection.AddTransient<IproductoCRUD, CRUDProduc>();
            //serviceCollection.AddTransient<IcategoriaCRUD, categoriaCRUD>();
            //serviceCollection.AddTransient<IsuplidoresCRUD, suplidoresCRUD>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmStart());
        }
    }
}