using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAO.Models.Core;

namespace DAO.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<CartLine> CartLines { get; set; }
        public bool IsDone { get; set; }
        
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }

        // public Time Time { get; set; }  //todo  
        
        [Required(ErrorMessage = "Enter your Address ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter your City")]
        public string City { get; set; }

        [RegularExpression(".+\\@.+\\ .. +",
            ErrorMessage = "Please enter а valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your Phone number")]
        public string Phone { get; set; }

        public bool GiftWrap { get; set; }
    }
}