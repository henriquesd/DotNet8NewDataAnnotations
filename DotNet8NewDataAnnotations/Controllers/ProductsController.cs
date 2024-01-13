using DotNet8NewDataAnnotations.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8NewDataAnnotations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Product product)
        {
            if (!ModelState.IsValid) return BadRequest();

            return Ok("Valid ModelState");
        }
    }
}