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

            // Aqu� ir�a la l�gica para verificar las credenciales del usuario
            // Por ahora, seg�n la gu�a, lo manejaremos en memoria.
            if (User.Email == "test@example.com" && User.Password == "password")
            {
                // Autenticaci�n exitosa (temporal)
                // Aqu� necesitar�amos establecer la cookie de autenticaci�n
                return RedirectToPage("/Index"); // Redirigir a la p�gina principal
            }
            else
            {
                // Credenciales inv�lidas
                ModelState.AddModelError(string.Empty, "Credenciales inv�lidas.");
                return Page();
            }
        }

        public void OnGet()
        {
        }
    }
}
