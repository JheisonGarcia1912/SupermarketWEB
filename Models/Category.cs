// SupermarketWEB/Models/Category.cs
using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        // Propiedad de navegación para los productos en esta categoría
        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
