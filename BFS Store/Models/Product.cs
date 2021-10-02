using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SportStore.Models
{
    public class Product
    {
        public long Id { get; set; }
        // [Required(ErrorMessage = "Enter product name")]
        public string Name { get; set; }
        // [Required(ErrorMessage = "Enter product description")]
        public string Description { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        // [Required(ErrorMessage = "Enter product price")]
        // [Range(0.01, double.MaxValue, ErrorMessage = "Enter positive product price")]
        // public string Banner { get; set; }
        public decimal Price { get; set; }
        public ProductInfo Info { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}