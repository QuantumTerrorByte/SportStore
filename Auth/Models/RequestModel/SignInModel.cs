using System.ComponentModel.DataAnnotations;

namespace Auth.Models.RequestModel
{
    public class SignInModel
    {
        [Required] 
        [EmailAddress] 
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Must be 8-20 characters")]
        public string Email { get; set; }

        [Required] 
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Must be 8-20 characters")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}