using BrightAcademyApp.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BrightAcademyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : CustomControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public UsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var userList = _userManager.Users;
            return Ok(userList);

        }
        [HttpGet("{userId}")]
        public async  Task<IActionResult> GetUser(string userId )
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {       
                return Ok(user);
            }
            return NotFound("Kullanıcı bulunamadı.");
         
        }

       
    }
}
