using System.ComponentModel.DataAnnotations;

namespace QuickPOS.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Range(0.01, 999999)]
        public decimal Price { get; set; }

        [Range(0, 999999)]
        public int Stock { get; set; }
    }
}
