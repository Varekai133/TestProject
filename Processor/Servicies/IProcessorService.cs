using Processor.Models;
using Processor.Data.DTO;
using SharedClassLibrary.Data.DTO;
using SharedClassLibrary.Models;

namespace Processor.Servicies;

public interface IProcessorService {
    Task ProcessEvent(Event e);
    Task<Incident> CreateIncident(Event e);
    void SaveIncidentToDb(Incident incident);
    bool isIncidentSimple(Event e);
    bool isIncidentComposite(Event e);
    List<Incident> GetListOfIncidentsOnly();
    List<Event> GetListOfEventsBasesOn(Incident incident);
    List<object> GetListOfIncidentsAndEventsBasedOn();
}