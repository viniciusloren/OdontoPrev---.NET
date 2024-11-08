using Microsoft.AspNetCore.Mvc;

namespace CHALLENGE.Application
{
    [ApiController] 
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello, World!"); 
        }
    }

}