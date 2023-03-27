using ClassRepository.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceLibrary.Abstract;

namespace ormation_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }
        [HttpGet("Restaurant")]
        public async Task<ActionResult<List<Restaurant>>> Getall()
        {

            return Ok( await _service.GetRestaurantsAsync());
        }
        [HttpGet("Restaurant/{id}")]
        public async Task<ActionResult<Restaurant>> Get(int id)
        {
            return Ok(await _service.GetRestaurantAsync(id));
        }
        [HttpPut("Update")]
        public async Task<IActionResult> update([FromBody] Restaurant restaurant)
        {
            try
            {
                 await _service.UpdateRestaurantAsync(restaurant);
                return Ok("Updated succesfully");
            }
            catch
            {
                return BadRequest("Error accured");
            }
           
          
        }
        [HttpPost("create")]
        public async Task<ActionResult<Restaurant>> create([Bind("Name", "Description")] Restaurant restaurant)
        {
            try
            {

                await _service.AddRestaurantAsync(restaurant);
                return Ok("created successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("delete")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                await _service.DeleteRestaurantAsync(id);
                return Ok("deleted succesfully");
            }
            catch
            {
               return BadRequest("Error accured");
            }
           
             
        }
    }
}
