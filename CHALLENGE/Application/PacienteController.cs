using CHALLENGE.Application;
using CHALLENGE.Domain;
using CHALLENGE.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class PacienteController : Controller
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteController(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public async Task<IActionResult> Index()
    {
        var pacientes = await _pacienteRepository.GetAllPacientesAsync();
        return View(pacientes);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(PacienteViewModel model)
    {
        if (ModelState.IsValid)
        {
            var paciente = new Paciente
            {
                Nome = model.Nome,
                TipoPlano = model.TipoPlano,
                Sexo = model.Sexo,
                Cep = model.Cep,
                DataNascimento = model.DataNascimento,
            };

            await _pacienteRepository.AddPacienteAsync(paciente);
            return RedirectToAction("Index");
        }
        return View(model);
    }

    public async Task<IActionResult> Details(int id)
    {
        var paciente = await _pacienteRepository.GetPacienteByIdAsync(id);
        if (paciente == null)
        {
            return NotFound();
        }
        return View(paciente);
    }
}