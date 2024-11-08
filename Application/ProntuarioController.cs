using CHALLENGE.Application;
using CHALLENGE.Domain;
using CHALLENGE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CHALLENGE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProntuarioController : ControllerBase
    {
        private readonly IProntuarioRepository _prontuarioRepository;

        public ProntuarioController(IProntuarioRepository prontuarioRepository)
        {
            _prontuarioRepository = prontuarioRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CriarProntuario([FromBody] ProntuarioViewModel prontuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prontuario = new Prontuario
            {
                Nome = prontuarioViewModel.Nome,
                TipoPlano = prontuarioViewModel.TipoPlano,
                Descricao = prontuarioViewModel.Descricao,
                StatusProntuario = prontuarioViewModel.StatusProntuario,
                Id = prontuarioViewModel.Id
            };

            await _prontuarioRepository.AddProntuarioAsync(prontuario);
            return CreatedAtAction(nameof(GetProntuarioById), new { id = prontuario.Id }, prontuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProntuarioById(int id)
        {
            var prontuario = await _prontuarioRepository.GetProntuariosByIdAsync(id);
            if (prontuario == null)
            {
                return NotFound();
            }
            return Ok(prontuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarProntuario(int id, [FromBody] ProntuarioViewModel prontuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prontuario = await _prontuarioRepository.GetProntuariosByIdAsync(id);
            if (prontuario == null)
            {
                return NotFound();
            }

            prontuario.Nome = prontuarioViewModel.Nome;
            prontuario.TipoPlano = prontuarioViewModel.TipoPlano;
            prontuario.Descricao = prontuarioViewModel.Descricao;
            prontuario.StatusProntuario = prontuarioViewModel.StatusProntuario;
            prontuario.Id = prontuarioViewModel.Id;

            await _prontuarioRepository.UpdateProntuarioAsync(prontuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarProntuario(int id)
        {
            var prontuario = await _prontuarioRepository.GetProntuariosByIdAsync(id);
            if (prontuario == null)
            {
                return NotFound();
            }

            await _prontuarioRepository.DeleteProntuarioAsync(id);
            return NoContent();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetTodosProntuarios()
        {
            var prontuarios = await _prontuarioRepository.GetAllProntuariosAsync();
            return Ok(prontuarios);
        }

        [HttpGet("paciente/{pacienteId}")]
        public async Task<IActionResult> GetProntuariosByPacienteId(int Id)
        {
            var prontuarios = await _prontuarioRepository.GetProntuariosByPacienteIdAsync(Id);
            return Ok(prontuarios);
        }
    }
}