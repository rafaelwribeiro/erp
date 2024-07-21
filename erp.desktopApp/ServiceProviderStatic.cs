using erp.desktopApp.Forms.Dashboard;
using erp.desktopApp.Forms.Login;
using Microsoft.Extensions.DependencyInjection;
using erp.crosscutting.AppDependencies;
using erp.desktopApp.Forms.Product;
using erp.desktopApp.Forms.Order;

namespace erp.desktopApp;

public static class ServiceProviderStatic
{
    private static ServiceProvider? serviceProvider = null;

    public static ServiceProvider Setup()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddInfrastructure(null);
        //serviceCollection.AddTransient<FormMainMenu>();
        serviceCollection.AddTransient<FormLogin>();
        serviceCollection.AddTransient<FormDashboard>();
        serviceCollection.AddTransient<FormListProducts>();
        serviceCollection.AddTransient<FormEditProduct>();
        serviceCollection.AddTransient<FormListOrder>();

        return serviceProvider = serviceCollection.BuildServiceProvider();
    }

    public static ServiceProvider GetServiceProvider()
    {
        if(serviceProvider == null)
            return Setup();
        return serviceProvider;
    }
}
