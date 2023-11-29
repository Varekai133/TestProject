using SharedClassLibrary.Models;

namespace Processor.Servicies;

public class BackgroundIncidentProcessor : BackgroundService
{
    private readonly IProcessorService _processorService;
    private readonly ManualResetEventSlim _eventSignal = new ManualResetEventSlim(false);

    public BackgroundIncidentProcessor(IProcessorService processorService) {
        _processorService = processorService;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        while (!stoppingToken.IsCancellationRequested) {
            await Task.Delay(1, stoppingToken);
        }
    }
}