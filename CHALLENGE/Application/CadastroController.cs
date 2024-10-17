using CHALLENGE.Application;
using CHALLENGE.Domain;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CadastroController : ControllerBase
{
    private readonly ICadastroRepository _cadastroRepository;

    public CadastroController(ICadastroRepository cadastroRepository)
    {
        _cadastroRepository = cadastroRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cadastros = await _cadastroRepository.GetAllCadastrosAsync();
        return Ok(cadastros);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var cadastro = await _cadastroRepository.GetCadastroByIdAsync(id);
        if (cadastro == null)
        {
            return NotFound();
        }
        return Ok(cadastro);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Cadastro cadastro)
    {
        if (cadastro == null)
        {
            return BadRequest();
        }

        await _cadastroRepository.AddCadastroAsync(cadastro);
        return CreatedAtAction(nameof(GetById), new { id = cadastro.Id }, cadastro);
    }
}