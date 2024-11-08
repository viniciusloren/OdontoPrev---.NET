using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CHALLENGE.Models; 
using CHALLENGE.Data; 

namespace CHALLENGE.Views.Pacientes
{
    public class CreateCadastro : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateCadastro(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Paciente Paciente { get; set; } // Certifique-se de que 'Paciente' é a classe do seu modelo

        public IActionResult OnGet()
        {
            return Page(); // Retorna a página para o método GET
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Retorna à página se o modelo não é válido
            }

            _context.Pacientes.Add(Paciente); // Adiciona o novo paciente ao contexto
            await _context.SaveChangesAsync(); // Salva as mudanças no banco de dados

            return RedirectToPage("./Index"); // Redireciona para a página de índice após a criação
        }
    }
}