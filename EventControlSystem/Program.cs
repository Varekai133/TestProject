using Generator.Servicies;
using Processor.Servicies;
using Processor.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddDbContext<IncidentsDbContext>(o => o.UseSqlite("filename=../Processor/Data/Database/Incidents.db"), ServiceLifetime.Singleton);
builder.Services.AddTransient<IGeneratorService, GeneratorService>();
builder.Services.AddHostedService<BackgroundEventGenerator>();
builder.Services.AddSingleton<IProcessorService, ProcessorService>();
builder.Services.AddScoped<BackgroundIncidentProcessor>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();