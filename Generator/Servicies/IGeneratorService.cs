using Generator.Models;

namespace Generator.Servicies;

public interface IGeneratorService {
    void GenerateEvent();
    void SendEventToProcessor(Event e);
}