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
        [HttpGet("Ayoub")]
        public IActionResult Getall()
        {

            return Ok(_service.GetRestaurants());
        }
        [HttpGet("Ayoub/{id}")] 
        public IActionResult Get(int id) 
        {
            return Ok(_service.GetRestaurant(id));
        }
        [HttpPut("Update")]
        public IActionResult update([FromBody]Restaurant restaurant)
        {
            var res = _service.Update(restaurant);
            return res ? Ok("Updated succesfully")  : BadRequest("Error accured");
        }
        [HttpPost("create")]
        public IActionResult create([Bind("Name","Description")] Restaurant restaurant)
        {
            try
            {
                
                _service.Create(restaurant);
                return Ok("created successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpDelete("delete")]
        public IActionResult delete(int id)
        {
            var res = _service.Delete(id);
            return res ? Ok("deleted succesfully") : BadRequest("Error accured");
        }
    }
}
