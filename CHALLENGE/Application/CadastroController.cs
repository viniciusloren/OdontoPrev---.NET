using CHALLENGE.Application;
using CHALLENGE.Domain;
using CHALLENGE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CHALLENGE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario([FromBody] CadastroViewModel cadastroViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = new Cadastro
            {
                Nome = cadastroViewModel.Nome,
                Sobrenome = cadastroViewModel.Sobrenome,
                Email = cadastroViewModel.Email,
                Senha = cadastroViewModel.Senha,
                DataNascimento = cadastroViewModel.DataNascimento,
                Sexo = cadastroViewModel.Sexo,
                TipoPlano = cadastroViewModel.TipoPlano,
                Cep = cadastroViewModel.Cep
            };

            await _cadastroRepository.AddUsuarioAsync(usuario);
            return CreatedAtAction(nameof(GetUsuarioById), new { id = usuario.Id }, usuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _cadastroRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarUsuario(int id, [FromBody] CadastroViewModel cadastroViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _cadastroRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Nome = cadastroViewModel.Nome;
            usuario.Sobrenome = cadastroViewModel.Sobrenome;
            usuario.Email = cadastroViewModel.Email;
            usuario.Senha = cadastroViewModel.Senha;
            usuario.DataNascimento = cadastroViewModel.DataNascimento;
            usuario.Sexo = cadastroViewModel.Sexo;
            usuario.TipoPlano = cadastroViewModel.TipoPlano;
            usuario.Cep = cadastroViewModel.Cep;

            await _cadastroRepository.UpdateUsuarioAsync(usuario);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarUsuario(int id)
        {
            var usuario = await _cadastroRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            await _cadastroRepository.DeleteUsuarioAsync(id);
            return NoContent(); 
        }

        [HttpGet]
        public async Task<IActionResult> GetTodosUsuarios()
        {
            var usuarios = await _cadastroRepository.GetAllUsuariosAsync();
            return Ok(usuarios);
        }
    }
}
