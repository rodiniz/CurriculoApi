using curriculoapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace curriculoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienciasController : BaseCrudController<Experiencia>
    {

        public ExperienciasController(LiteDbContext context) : base(context)
        {
        }
    }
}