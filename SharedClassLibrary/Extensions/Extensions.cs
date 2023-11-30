using SharedClassLibrary.Data.DTO;
using SharedClassLibrary.Models;

namespace SharedClassLibrary.Extensions;

public static class Extensions {
    public static EventDTO AsDto(this Event e) {
        return new EventDTO {
            Id = e.Id,
            Type = e.Type,
            Time = e.Time
        };
    }
}