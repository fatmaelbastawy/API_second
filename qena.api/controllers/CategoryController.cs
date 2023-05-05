using context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace qena.api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly Context context;

        public CategoryController(Context _context)
        {
            context = _context;
        }

        // localhost:7063/api/Product/all
        [HttpGet("all")]
        public IActionResult GetAllCategory()
        {
            try
            {
                return Ok(context.Catigoes.Select(c => new { c.Name }));
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }

        }
        // localhost:7063/api/Product/5
        [HttpGet("{id}")]
        public IActionResult GetAllCategoriesbyID(int id)
        {
            try
            {
                return Ok(context.Catigoes.Where(p => p.ID == id));
            }
            catch (Exception)
            {
                return BadRequest("Sorry Data Not Available");
            }

        }
    }

}
