using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<string>
            {
                "Laptop",
                "Mobile",
                "Keyboard"
            };

            return Ok(products);
        }
    }
}