using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = new List<string>
            {
                "Order 101",
                "Order 102",
                "Order 103"
            };

            return Ok(orders);
        }
    }
}