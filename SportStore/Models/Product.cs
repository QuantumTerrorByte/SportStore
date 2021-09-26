using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter product description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter product category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Enter product price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Enter positive product price")]
        public decimal Price { get; set; }
    }
}