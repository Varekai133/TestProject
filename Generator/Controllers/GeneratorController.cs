using Generator.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Generator.Controllers;

[ApiController]
[Route("[controller]")]
public class GeneratorController : ControllerBase
{    private readonly IGeneratorService _generatorService;

    public GeneratorController(IGeneratorService generatorService) {
        _generatorService = generatorService;
    }

    [HttpPost("GenerateEventManually")]
    public void GenerateEventManually([FromBody] int ?type) {
        _generatorService.GenerateEvent(type);
    }
}
