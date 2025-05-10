using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models // Cambia a Models (plural)
{
    public class User // Cambia a User (singular)
    {
        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
