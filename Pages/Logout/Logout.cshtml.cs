using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;

namespace Autenticacion.Pages.Account // Namespace según la imagen
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync() // Método OnPost
        {
            await HttpContext.SignOutAsync("MyCookieAuth"); // Usando el esquema que configuramos
            return RedirectToPage("/Index");
        }


    }
}
      