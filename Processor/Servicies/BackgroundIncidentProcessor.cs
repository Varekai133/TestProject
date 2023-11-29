using SharedClassLibrary.Models;

namespace Processor.Servicies;

public class BackgroundIncidentProcessor : BackgroundService
{
    private readonly IProcessorService _processorService;

    public BackgroundIncidentProcessor(IProcessorService processorService) {
        _processorService = processorService;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        // while (!stoppingToken.IsCancellationRequested) {

        // }
    }
}