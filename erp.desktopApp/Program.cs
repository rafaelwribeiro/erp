using erp.desktopApp.Forms.Login;
using Microsoft.Extensions.DependencyInjection;

namespace erp.desktopApp;

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
        try
        {
            ApplicationConfiguration.Initialize();
            ServiceProviderStatic.Setup();
            var sp = ServiceProviderStatic.GetServiceProvider();
            var login = sp.GetRequiredService<FormLogin>();
            if(login.ShowDialog()==DialogResult.OK)
                Application.Run(new FormMainMenu());
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
        /*Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddInfrastructure(null);
        serviceCollection.AddTransient<FormMainMenu>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var form = serviceProvider.GetRequiredService<FormMainMenu>();

        Application.Run(form);*/
    }
}