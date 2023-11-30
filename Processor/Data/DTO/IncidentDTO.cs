using System.ComponentModel.DataAnnotations;
using SharedClassLibrary.Models;
using Processor.Models;

namespace Processor.Data.DTO;

public class IncidentDTO {
    public Guid Id { get; set; }
    public IncidentTypeEnum Type { get; set; }
    public DateTime Time { get; set; }
    public List<Event> EventsBasedOn { get; set; }
}