using System;
using System.Collections.Generic;

namespace DAO.Models
{
    public class AppUser
    {
        public List<LikeJunction> LikeJunction { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}