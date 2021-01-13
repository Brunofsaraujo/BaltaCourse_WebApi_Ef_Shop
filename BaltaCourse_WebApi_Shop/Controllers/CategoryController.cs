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
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "Olá mundo Get!";
        }

        [HttpPost]
        [Route("")]
        public Category Post([FromBody] Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("{id:int}")]
        public Category Put(int id, [FromBody] Category model)
        {
            if (model.Id == id)
                return model;

            return null;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public string Delete()
        {
            return "Olá mundo Delete!";
        }
    }
}