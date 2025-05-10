using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } // Será la llave primaria

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        // Propiedad de navegación
        public ICollection<Product>? Products { get; set; }
    }
}
