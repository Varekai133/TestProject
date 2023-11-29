using Generator.Models;

namespace Generator.Servicies;

public class GeneratorService : IGeneratorService
{
    public void GenerateEvent() {
        //throw new NotImplementedException();
        Console.WriteLine("Generate event");
    }

    public void SendEventToProcessor(Event e) {
        throw new NotImplementedException();
    }
}