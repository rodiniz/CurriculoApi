using System;
using System.Threading.Tasks;
using curriculoapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace curriculoapi.Controllers
{
    public abstract class BaseCrudController<T> : Controller where T : class, IEntity
    {
        private readonly LiteDbContext _context;

        protected BaseCrudController(LiteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get")]
        public virtual ActionResult<T> Get(int id)
        {
            var ret = _context.Set<T>().Find(id);

            return ret == null ? NotFound() : Ok(ret);
        }

        

        [HttpDelete]
        public virtual async Task<IActionResult> Delete(int id)
        {
            try
            {
                var ret = await _context.Set<T>().FindAsync(id);
                if(ret == null)
                {
                    return NotFound();
                }
                _context.Remove(ret);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }
    }
}