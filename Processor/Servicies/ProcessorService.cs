using Processor.Models;
using SharedClassLibrary.Models;

namespace Processor.Servicies;

public class ProcessorService : IProcessorService
{
    private bool _isWaitingForType1 {get; set;}
    public async Task ProcessEvent(Event e) {
        Console.WriteLine("Recieved event type: " + e.Type.ToString());
        await CreateIncident(e);
        //SaveIncidentToDb();
    }

    public async Task<Incident> CreateIncident(Event e) {
        if (isIncidentSimple(e)) {
            if (_isWaitingForType1) {
                Console.WriteLine("Composite");
                _isWaitingForType1 = false;
                return new Incident {
                    Id = Guid.NewGuid(),
                    Type = IncidentTypeEnum.Simple,
                    Time = DateTime.UtcNow
                };
            }
            else {
                Console.WriteLine("Simple");
                return new Incident {
                    Id = Guid.NewGuid(),
                    Type = IncidentTypeEnum.Simple,
                    Time = DateTime.UtcNow
                };
            }
        }
        if (isIncidentComposite(e)) {
            if (!_isWaitingForType1) {
                _isWaitingForType1 = true;

                await Task.Delay(20000);
            }
        }
        
        return null;
    }

    public bool isIncidentSimple(Event e) {
        return e.Type == EventTypeEnum.Type1;
    }

    public bool isIncidentComposite(Event e) {
        return e.Type == EventTypeEnum.Type2;
    }

    public void SaveIncidentToDb() {
        throw new NotImplementedException();
    }

    public void ShowListOfIncidents() {
        throw new NotImplementedException();
    }
}