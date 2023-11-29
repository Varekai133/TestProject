using Generator.Models;

namespace Generator.Servicies;

public class BackgroundEventGenerator : BackgroundService
{
    private readonly IGeneratorService _generatorService;
    private readonly Random _random = new Random();
    
    public BackgroundEventGenerator(IGeneratorService generatorService) {
        _generatorService = generatorService;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
        while (!stoppingToken.IsCancellationRequested) {
            await _generatorService.GenerateEvent();
            var sleepTime = _random.Next(0, 2000);
            await Task.Delay(sleepTime, stoppingToken);
        }
    }
}