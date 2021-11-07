using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesApiController : ControllerBase
    {
        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<AppUser> _userManager;
        public UserRolesApiController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        
        
        
    }
}