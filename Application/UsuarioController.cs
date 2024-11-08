using CHALLENGE.Application;
using CHALLENGE.Domain;
using CHALLENGE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CHALLENGE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = new Usuario
            {
                Nome = usuarioViewModel.Nome,
                Sobrenome = usuarioViewModel.Sobrenome,
                Email = usuarioViewModel.Email,
                Senha = usuarioViewModel.Senha,
                DataNascimento = usuarioViewModel.DataNascimento,
                Sexo = usuarioViewModel.Sexo,
                TipoPlano = usuarioViewModel.TipoPlano,
                Cep = usuarioViewModel.Cep,
                Id = 1
            };

            await _usuarioRepository.AddUsuarioAsync(usuario);
            return CreatedAtAction(nameof(GetUsuarioById), new { id = usuario.Id }, usuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarUsuario(int id, [FromBody] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _usuarioRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Nome = usuarioViewModel.Nome;
            usuario.Sobrenome = usuarioViewModel.Sobrenome;
            usuario.Email = usuarioViewModel.Email;
            usuario.Senha = usuarioViewModel.Senha;
            usuario.DataNascimento = usuarioViewModel.DataNascimento;
            usuario.Sexo = usuarioViewModel.Sexo;
            usuario.TipoPlano = usuarioViewModel.TipoPlano;
            usuario.Cep = usuarioViewModel.Cep;

            await _usuarioRepository.UpdateUsuarioAsync(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            await _usuarioRepository.DeleteUsuarioAsync(id);
            return NoContent();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetTodosUsuarios()
        {
            var usuarios = await _usuarioRepository.GetAllUsuariosAsync();
            return Ok(usuarios);
        }
    }
}