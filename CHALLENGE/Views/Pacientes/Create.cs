using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CHALLENGE.Views.Pacientes;
using System.Threading.Tasks;
using CHALLENGE.Domain;

public class CreateModel : PageModel
{
    [BindProperty]
    public Paciente Paciente { get; set; }

    private readonly PacienteContext _context;

    public CreateModel(PacienteContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Pacientes.Add(Paciente);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index"); // Altere para a página de listagem, se necessário
    }
}

       
       

