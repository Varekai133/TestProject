using SharedClassLibrary.Models;

namespace Generator.Servicies;

public interface IGeneratorService {
    Task GenerateEvent(int ?type);
    Task SendEventToProcessor(Event e);
}