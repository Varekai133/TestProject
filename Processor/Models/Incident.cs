using SharedClassLibrary.Models;

namespace Processor.Models;

public class Incident {
    public Guid Id { get; set; }
    public IncidentTypeEnum Type { get; set; }
    public DateTime Time { get; set; }
    public List<Event> EventsBasedOn { get; set; }
}
