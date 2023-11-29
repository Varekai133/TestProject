using Processor.Servicies;
using Microsoft.AspNetCore.Mvc;
using SharedClassLibrary.Models;

namespace Processor.Controllers;

[ApiController]
[Route("[controller]")]
public class ProcessorController : ControllerBase
{
    private readonly IProcessorService _processorService;

    public ProcessorController(IProcessorService processorService) {
        _processorService = processorService;
    }

    [HttpPost("ProcessEvent")]
    public void ReceiceEvent([FromBody] Event e) {
        _processorService.ProcessEvent(e);
    }

    // [HttpGet("GetListOfIncidents")]
    // public void GetListOfIncidents() {
        
    // }
}