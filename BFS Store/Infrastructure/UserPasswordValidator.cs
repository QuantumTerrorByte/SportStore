using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SportStore.Models;

namespace SportStore.Infrastructure
{
    public class UserPasswordValidator: PasswordValidator<AspNetUser>
    {
        public override async Task<IdentityResult> ValidateAsync(
            UserManager<AspNetUser> manager, AspNetUser user, string password)
        {
            var baseValidationResult = await base.ValidateAsync(manager, user, password);
            var errors = baseValidationResult.Succeeded
                ? new List<IdentityError>()
                : baseValidationResult.Errors.ToList();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError {Code = "PassContainUserName", Description = "Pass cant contain name"});
            }

            return await Task.FromResult(errors.Count == 0
                ? IdentityResult.Success
                : IdentityResult.Failed(errors.ToArray()));
        }
    }
}