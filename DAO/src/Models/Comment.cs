using System;
using System.ComponentModel.DataAnnotations;
using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string AuthorId { get; set; }
        public AppUser Author { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        
        [StringLength(300, MinimumLength = 5, ErrorMessage = "content length must be 5-300 symbols")]
        public string Content { get; set; }
        
        public DateTime Created { get; set; }
        public bool IsEdited { get; set; }
    }
}