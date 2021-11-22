using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Auth.Models
{
    public class AppUserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IsAuthorized { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AuthType { get; set; }
        
        public List<IdentityRole> InRoles { get; set; }
    }
}