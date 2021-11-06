using System.ComponentModel.DataAnnotations;

namespace SportStore.Models.RequestModel
{
    public class UserAuthModel
    {
        [Required] [EmailAddress] 
        public string Email { get; set; }

        [Required] 
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}