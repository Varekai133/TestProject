using Generator.Models;

namespace Generator.Servicies;

public class BackgroundEventGenerator : BackgroundService
{
    private readonly IGeneratorService _generatorService;
    
    public BackgroundEventGenerator(IGeneratorService generatorService) {
        _generatorService = generatorService;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        while (!stoppingToken.IsCancellationRequested) {
            _generatorService.GenerateEvent();
            await Task.Delay(2000, stoppingToken);
        }
    }
}