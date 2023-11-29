using Processor.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Processor.Controllers;

[ApiController]
[Route("[controller]")]
public class ProcessorController : ControllerBase
{
    private readonly IProcessorService _processorService;

    public ProcessorController(IProcessorService processorService) {
        _processorService = processorService;
    }

    [HttpGet("ProcessEvents")]
    public void ProcessEvents() {
        _processorService.ProcessEvents();
    }

    [HttpGet("GetListOfIncidents")]
    public void GetListOfIncidents() {
        
    }
}