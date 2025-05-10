using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Será la llave foránea

        // Propiedad de navegación
        public Category? Category { get; set; }
    }
}