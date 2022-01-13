using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteSharepointNovo.Models;

namespace curriculoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurriculoController :Controller
    {
        private LiteDbContext _context;
        public CurriculoController(LiteDbContext context)
        {
            _context = context;
        }
        //create    
        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Curriculo model)
        {
            try
            {
                var ret = await _context.Curriculos.FindAsync(model.Id);

                if (ret == null)
                {
                    return NotFound();
                }

                _context.Update(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Curriculo model)
        {
            try
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }
        //delete
        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var ret = await _context.Curriculos.FindAsync(id);

                if (ret == null)
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
