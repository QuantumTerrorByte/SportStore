using System.ComponentModel.DataAnnotations;

namespace DAO.Models.RequestModel
{
    public class SignUpModel : SignInModel
    {
        [Required]
        [RegularExpression(@"\d{9,15}", ErrorMessage = "Phone length must be in diapason 10-15 symbols")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name must be in diapason 5-20 symbols")]
        public string UserName { get; set; }
    }
}