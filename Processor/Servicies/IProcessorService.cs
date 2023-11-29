namespace Processor.Servicies;

public interface IProcessorService {
    void ProcessEvents();
    void CreateIncident();
    void SaveIncidentToDb();
    bool isIncidentSimple();
    bool isIncidentComposite();
    void ShowListOfIncidents();
}