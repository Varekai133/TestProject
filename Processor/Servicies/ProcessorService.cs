namespace Processor.Servicies;

public class ProcessorService : IProcessorService
{
    public void ProcessEvents() {
        Console.WriteLine("Process event");
    }

    public void CreateIncident(){
        throw new NotImplementedException();
    }

    public bool isIncidentComposite(){
        throw new NotImplementedException();
    }

    public bool isIncidentSimple(){
        throw new NotImplementedException();
    }

    public void SaveIncidentToDb(){
        throw new NotImplementedException();
    }

    public void ShowListOfIncidents() {
        throw new NotImplementedException();
    }
}