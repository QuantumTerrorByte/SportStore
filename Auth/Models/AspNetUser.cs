using System;
using Microsoft.AspNetCore.Identity;

namespace Auth.Models
{
    public class AspNetUser: IdentityUser
    {
        public DateTime RegistrationDate { get; set; }
    }
}