using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_Api_PV221.Helpers;

namespace Shop_Api_PV221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService carsService;

        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10,
                                         [FromQuery] string? make = null, [FromQuery] string? category = null,
                                         [FromQuery] string? sortDirection = null)
        {
            var (cars, totalCount) = await carsService.GetAll(page, pageSize, make, category, sortDirection);

            return Ok(new
            {
                items = cars,
                totalCount
            });
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            return Ok(await carsService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCarModel model)
        {
            carsService.Create(model);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] CarDto model)
        {
            carsService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute]int id)
        {
            carsService.Delete(id);
            return Ok(); 
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            return Ok(carsService.GetAllCategories());
        }

        [HttpGet("makes")]
        public ActionResult<IEnumerable<string>> GetMakes()
        {
            return Ok(carsService.GetAllMakes());
        }

    }
}
