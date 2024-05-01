using Microsoft.Extensions.DependencyInjection;
using erp.crosscutting.AppDependencies;

namespace erp.desktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddInfrastructure(null);
            serviceCollection.AddTransient<Form1>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}