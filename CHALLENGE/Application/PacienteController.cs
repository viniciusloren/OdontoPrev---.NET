using CHALLENGE.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CHALLENGE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        // Ação para criar um paciente
        [HttpPost("create")]
        public IActionResult Create([FromBody] PacienteViewModel paciente)
        {
            // Lógica para criar o paciente
            return Ok();
        }

        // Ação para obter todos os pacientes
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            // Lógica para obter todos os pacientes
            return Ok();
        }
    }
}