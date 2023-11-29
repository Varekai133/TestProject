using System.Net;
using SharedClassLibrary.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Generator.Servicies;

public class GeneratorService : IGeneratorService
{
    private readonly HttpClient _client;
    //private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly Random _random = new Random();
    
    public GeneratorService(HttpClient client) {
        _client = client;
    }

    public async Task GenerateEvent() {
        var eventType = (EventTypeEnum)_random.Next(1, Enum.GetValues(typeof(EventTypeEnum)).Length + 1);
        var newEvent = new Event() {
            Id = Guid.NewGuid(),
            Type = eventType,
            Time = DateTime.UtcNow
        };
        //Console.WriteLine("Generated newEvent: " + newEvent.Id);
        await SendEventToProcessor(newEvent);
    }

    public async Task SendEventToProcessor(Event e) {
        try {
            // var request = _httpContextAccessor.HttpContext?.Request;
            // var baseUri = $"{request.Scheme}://{request.Host}";
            var apiUrl = "https://localhost:7224/Processor/ProcessEvent"; // TODO: localhost -> host

            var response = await _client.PostAsJsonAsync(apiUrl, e);

            response.EnsureSuccessStatusCode();
        }
        catch (Exception ex) {
        }
    }
}