using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Api_PV221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await cartService.GetProducts();
            return Ok(items);
        }

        [HttpPost("{id:int}")]
        public IActionResult Add([FromRoute] int id)
        {
            cartService.Add(id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove([FromRoute] int id)
        {
            cartService.Remove(id);
            return Ok();
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(cartService.GetCount());
        }

        [HttpGet("exists/{id:int}")]
        public IActionResult Exists([FromRoute] int id)
        {
            return Ok(cartService.IsExists(id));
        }

        [HttpGet("ids")]
        public IActionResult GetIds()
        {
            return Ok(cartService.GetProductIds());
        }

        [HttpDelete("clear")]
        public IActionResult Clear()
        {
            cartService.Clear();
            return Ok(new { message = "Cart cleared successfully." });
        }
    }
}
