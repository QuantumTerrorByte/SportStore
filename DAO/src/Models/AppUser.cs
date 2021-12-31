using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class AppUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength(40, MinimumLength = 5)]
        public string UserName { get; set; }
        [StringLength(40, MinimumLength = 5)]
        public string Email { get; set; }
        [StringLength(12, MinimumLength = 10)]
        public string Phone { get; set; }
        [StringLength(40, MinimumLength = 2)]
        public string FirstName { get; set; }
        [StringLength(40, MinimumLength = 2)]
        public string SecondName { get; set; }
        [StringLength(40, MinimumLength = 2)]
        public string Patronymic { get; set; }
        
        public long AddressId { get; set; }
        public Address Address { get; set; }

        public List<Product> Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }

}