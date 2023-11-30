using Processor.Models;
using SharedClassLibrary.Models;
using Processor.Data;

namespace Processor.Servicies;

public class ProcessorService : IProcessorService
{
    private Event _lastEvent { get; set; }
    private bool _isWaitingForType1 {get; set;}
    private readonly IncidentsDbContext _context;

    public ProcessorService(IncidentsDbContext context) => _context = context;

    public async Task ProcessEvent(Event e) {
        Console.WriteLine("Recieved event type: " + e.Type.ToString());
        var currentIncident = await CreateIncident(e);
        if (currentIncident != null) {
            Console.WriteLine(currentIncident.EventsBasedOn.Count);
            SaveIncidentToDb(currentIncident);
        }
    }

    public async Task<Incident> CreateIncident(Event e) {
        if (isIncidentSimple(e)) {
            if (_isWaitingForType1) {
                Console.WriteLine("Composite");
                _isWaitingForType1 = false;
                return new Incident {
                    Id = Guid.NewGuid(),
                    Type = IncidentTypeEnum.Composite,
                    Time = DateTime.UtcNow,
                    EventsBasedOn = new List<Event>() {
                        e, _lastEvent
                    }
                };
            }
            else {
                Console.WriteLine("Simple");
                return new Incident {
                    Id = Guid.NewGuid(),
                    Type = IncidentTypeEnum.Simple,
                    Time = DateTime.UtcNow,
                    EventsBasedOn = new List<Event>() {
                        e
                    }
                };
            }
        }
        if (isIncidentComposite(e)) {
            if (!_isWaitingForType1) {
                _isWaitingForType1 = true;
                _lastEvent = e;
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

    public void SaveIncidentToDb(Incident incident) {
        _context.Add(incident);
        _context.SaveChanges();
    }

    public async Task<List<Incident>> ShowListOfIncidents() {
        throw new NotImplementedException();
    }
}