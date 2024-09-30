using Microsoft.AspNetCore.Mvc;

namespace CHALLENGE.Application
{
    [ApiController] 
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello, World!"); 
        }
    }
}
