using SharedClassLibrary.Models;

namespace Processor.Servicies;

public interface IProcessorService {
    Task ProcessEvent(Event e);
    void CreateIncident();
    void SaveIncidentToDb();
    bool isIncidentSimple();
    bool isIncidentComposite();
    void ShowListOfIncidents();
}