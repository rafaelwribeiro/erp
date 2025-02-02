using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace erp.api.Services;

public class MyBackGroundService : BackgroundService
{
    private readonly ILogger<MyBackGroundService> _logger;

    public MyBackGroundService(ILogger<MyBackGroundService> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Serviço em segundo plano iniciado.");

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Executando tarefa em segundo plano a cada 1 minuto.");
            _logger.LogError("Teste de erro no serviço em segundo plano.");
            
            // Sua lógica ou tarefa
            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
        }

        _logger.LogInformation("Serviço em segundo plano encerrado.");
    }
}