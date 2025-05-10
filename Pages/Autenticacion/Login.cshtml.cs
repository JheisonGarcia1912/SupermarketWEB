using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

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

            // Verificación de credenciales en memoria
            if (User.Email == "correo@gmail.com" && User.Password == "12345")
            {
                // Se crea la lista de Claims, datos a almacenar en la Cookie
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, User.Email),
                    new Claim(ClaimTypes.Email, User.Email),
                    // Puedes agregar más claims aquí, por ejemplo, roles
                };

                // Se asocia los claims creados a un nombre de una Cookie
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");

                // Se agrega la identidad creada al ClaimsPrincipal de la aplicación
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                // Se registra exitosamente la autenticación y se crea la cookie en el navegador
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            else
            {
                // Credenciales inválidas
                ModelState.AddModelError(string.Empty, "Credenciales inválidas.");
                return Page(); // Regresa a la página de login para mostrar el error
            }
        }

        public void OnGet()
        {
        }
    }
}