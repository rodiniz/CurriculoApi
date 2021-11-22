using Microsoft.AspNetCore.Mvc;
using TesteSharepointNovo.Models;

namespace curriculoapi.Controllers;

[ApiController]
[Route("[controller]")]
public class CurriculoController : ControllerBase
{
   
    [HttpGet(Name = "GetResume")]
    public Curriculo Get()
    {
        return new Curriculo();

    }

    [HttpGet(Name = "Populate")]
    public ActionResult Populate()
    {
        return Ok();
    }
}
