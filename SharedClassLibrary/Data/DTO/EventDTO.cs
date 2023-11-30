using SharedClassLibrary.Models;

namespace SharedClassLibrary.Data.DTO;

public class EventDTO {
    public Guid Id {get; set;}
    public EventTypeEnum Type { get; set; }
    public DateTime Time { get; set; }
}