using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Auth.Models
{
    public class SeedData
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public SeedData(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task InitializeAsync()
        {
            var roles = new[] {"user", "admin", "operator"};
            foreach (var role in roles)
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}