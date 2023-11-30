using Processor.Models;
using SharedClassLibrary.Models;

namespace Processor.Servicies;

public interface IProcessorService {
    Task ProcessEvent(Event e);
    Task<Incident> CreateIncident(Event e);
    void SaveIncidentToDb(Incident incident);
    bool isIncidentSimple(Event e);
    bool isIncidentComposite(Event e);
    List<Incident> ShowListOfIncidents();
    List<Event> ShowListOfEventsBasesOn(Incident incident);
    List<object> ShowFullList();
}