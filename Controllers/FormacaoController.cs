using curriculoapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace curriculoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormacaoController : BaseCrudController<Formacao>
    {

        public FormacaoController(LiteDbContext context) : base(context)
        {
        }
    }
}