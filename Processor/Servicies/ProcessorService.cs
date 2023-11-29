using SharedClassLibrary.Models;

namespace Processor.Servicies;

public class ProcessorService : IProcessorService
{
    public async Task ProcessEvent(Event e) {
        Console.WriteLine("Recieved event id: " + e.Id.ToString());
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