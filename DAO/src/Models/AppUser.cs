using System;
using System.Collections.Generic;
using DAO.Models.ProductModel;

namespace DAO.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<Address> Addresses { get; set; }

        public List<Product> Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }

}