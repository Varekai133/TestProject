using SharedClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Processor.Models;

namespace Processor.Data;

public class IncidentsDbContext : DbContext {
    public DbSet<Incident> Incidents { get; set; }
    public IncidentsDbContext(DbContextOptions options) : base(options) {

    }
    public IncidentsDbContext() { }
}