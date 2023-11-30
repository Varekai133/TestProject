using System.ComponentModel.DataAnnotations;

namespace SharedClassLibrary.Models;

public class Event {
    [Key]
    public Guid Id {get; set;}
    public EventTypeEnum Type { get; set; }
    public DateTime Time { get; set; }
}