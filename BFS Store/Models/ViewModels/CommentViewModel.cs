using System.ComponentModel.DataAnnotations;

namespace SportStore.Models.ViewModels
{
    public class CommentViewModel
    {
        [Required] 
        public long ProductId { get; set; }
        [StringLength(300, MinimumLength = 5, ErrorMessage = "content length must be 5-300 symbols")]
        public string Content { get; set; }
    }
}