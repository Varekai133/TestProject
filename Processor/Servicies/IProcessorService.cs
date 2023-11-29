using Processor.Models;
using SharedClassLibrary.Models;

namespace Processor.Servicies;

public interface IProcessorService {
    Task ProcessEvent(Event e);
    Task<Incident> CreateIncident(Event e);
    void SaveIncidentToDb();
    bool isIncidentSimple(Event e);
    bool isIncidentComposite(Event e);
    void ShowListOfIncidents();
}