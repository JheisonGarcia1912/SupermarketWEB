using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;

namespace Autenticacion.Pages.Account // Namespace seg�n la imagen
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync() // M�todo OnPost
        {
            await HttpContext.SignOutAsync("MyCookieAuth"); // Usando el esquema que configuramos
            return RedirectToPage("/Index");
        }


    }
}
      