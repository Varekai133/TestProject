using Generator.Models;

namespace Generator.Servicies;

public class GeneratorService : IGeneratorService
{
    private readonly HttpClient _client;
    private readonly Random _random = new Random();
    
    public GeneratorService(HttpClient client) {
        _client = client;
    }

    public async Task GenerateEvent() {
        var eventType = (EventTypeEnum)_random.Next(1, Enum.GetValues(typeof(EventTypeEnum)).Length);
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
            var apiUrl = "api";
            var response = await _client.PostAsJsonAsync(apiUrl, e);
            //Console.WriteLine("Sent newEvent: " + response.StatusCode);

            response.EnsureSuccessStatusCode();
        }
        catch (Exception ex) {

        }
    }
}