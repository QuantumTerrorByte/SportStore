using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SportStore.Models
{
    public class AspNetUser: IdentityUser
    {
        public List<LikeJunction> LikeJunction { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}