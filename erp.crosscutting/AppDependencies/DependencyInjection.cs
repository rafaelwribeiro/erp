using erp.application.Service;
using erp.domain.Abstractions;
using erp.infra.Context;
using erp.infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace erp.crosscutting.AppDependencies;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration? configuration)
    {
        var mySqlConnection = configuration?.GetConnectionString("DefaultConnection")
                              ?? "Server=localhost;DataBase=erp;Uid=root;Pwd=root";

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection))
        );

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IStockMovementRepository, StockMovementRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IStockMovementService, StockMovementService>();

        var myhandlers = AppDomain.CurrentDomain.Load("erp.Application");
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(myhandlers));
        return services;
    }
}