using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Models;
using System.Threading.Tasks;


namespace SupermarketWEB.Pages.Autenticacion
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Aquí iría la lógica para verificar las credenciales del usuario
            // Por ahora, según la guía, lo manejaremos en memoria.
            if (User.Email == "test@example.com" && User.Password == "password")
            {
                // Autenticación exitosa (temporal)
                // Aquí necesitaríamos establecer la cookie de autenticación
                return RedirectToPage("/Index"); // Redirigir a la página principal
            }
            else
            {
                // Credenciales inválidas
                ModelState.AddModelError(string.Empty, "Credenciales inválidas.");
                return Page();
            }
        }

        public void OnGet()
        {
        }
    }
}
