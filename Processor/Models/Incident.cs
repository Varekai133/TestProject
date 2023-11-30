using SharedClassLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace Processor.Models;

public class Incident {
    [Key]
    public Guid Id { get; set; }
    public IncidentTypeEnum Type { get; set; }
    public DateTime Time { get; set; }
    public List<Event> EventsBasedOn { get; set; }
}
