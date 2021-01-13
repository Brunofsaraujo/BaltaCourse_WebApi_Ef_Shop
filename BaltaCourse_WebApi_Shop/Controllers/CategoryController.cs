using System.Collections.Generic;
using System.Threading.Tasks;
using BaltaCourse_WebApi_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaltaCourse_WebApi_Shop.Controllers
{
    // Endpoint => URL
    // http://localhost:5000/categories
    // https://localhost:5001/categories
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        // https://localhost:5001/categories
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return new Category();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Post([FromBody] Category model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category model)
        {
            if (model.Id != id)
                return NotFound(new { message = "Categoria não encontrada" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Delete()
        {
            return Ok();
        }
    }
}