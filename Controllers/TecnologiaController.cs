using curriculoapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace curriculoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TecnologiaController : BaseCrudController<Tecnologia>
    {

        public TecnologiaController(LiteDbContext context) : base(context)
        {
        }
    }
}