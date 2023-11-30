using System.Net;
using SharedClassLibrary.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Generator.Servicies;

public class GeneratorService : IGeneratorService
{
    private readonly HttpClient _client;
    private readonly string _listeningAddress;
    private readonly string _listeningPort;
    private readonly Random _random = new Random();
    
    public GeneratorService(HttpClient client, IConfiguration configuration) {
        _client = client;
        _listeningAddress = (configuration["ASPNETCORE_URLS"] ?? "http://localhost").Split(';').FirstOrDefault() ?? "http://localhost";
    }

    public async Task GenerateEvent(int ?type) {
        EventTypeEnum eventType = 0;
        if (type != null && type > 0 && type < Enum.GetValues(typeof(EventTypeEnum)).Length - 1) { 
            eventType = (EventTypeEnum)type;
        }
        else eventType = (EventTypeEnum)_random.Next(1, Enum.GetValues(typeof(EventTypeEnum)).Length - 1);
        var newEvent = new Event() {
            Id = Guid.NewGuid(),
            Type = eventType,
            Time = DateTime.UtcNow
        };
        await SendEventToProcessor(newEvent);
    }

    public async Task SendEventToProcessor(Event e) {
        try {            
            var apiUrl = _listeningAddress.ToString() + "/Processor/ProcessEvent";
            var response = await _client.PostAsJsonAsync(apiUrl, e);
            response.EnsureSuccessStatusCode();
        }
        catch (Exception ex) {
        }
    }
}