using Processor.Models;
using Processor.Data.DTO;
using SharedClassLibrary.Data.DTO;
using SharedClassLibrary.Models;

namespace Processor.Extensions;

public static class Extensions {
    public static IncidentDTO AsDto(this Incident incident) {
        return new IncidentDTO {
            Id = incident.Id,
            Type = incident.Type,
            Time = incident.Time,
            EventsBasedOn = incident.EventsBasedOn
        };
    }
}