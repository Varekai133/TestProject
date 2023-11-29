using Generator.Models;

namespace Generator.Servicies;

public interface IGeneratorService {
    Task GenerateEvent();
    Task SendEventToProcessor(Event e);
}