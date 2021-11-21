using System;
using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        
        public string Content { get; set; }
        
        public DateTime Created { get; set; }
        public bool IsEdited { get; set; }
        public DateTime Edited { get; set; }
        public string PreviousState { get; set; }
    }
}