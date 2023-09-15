using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BrightAcademyApp.API.Extensions
{
    public static class UserExtensions
    {
   
            public static List<IdentityUser> GetUsersWithRoles(this UserManager<IdentityUser> userManager)
            {
                var usersWithRoles = new List<IdentityUser>();

                foreach (var user in userManager.Users)
                {
                    var roles = userManager.GetRolesAsync(user.Id);
                    var userWithRoles = new UserDto
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        Role = roles
                    };
                    usersWithRoles.Add(userWithRoles);
                }

                return usersWithRoles;
            }

        }
    }
}
