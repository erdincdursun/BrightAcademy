using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.ControllerBases;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public async Task<IActionResult> GetUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("Kullanıcı bulunamadı.");

        }

        [HttpGet]
        [Route("/api/[controller]/GetAllUsersWithRoles")]
        public async Task<IActionResult> GetAllUsersWithRoles()
        {
            var usersWithRoles = _userManager.Users.Select(user => new
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Roles = _userManager.GetRolesAsync(user),
            }).ToList();
            return Ok(usersWithRoles);

        }

        [HttpGet]
        [Route("/api/[controller]/GetUserWithRole")]
        public async Task<IActionResult> GetUserWithRole(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound(); // Kullanıcı bulunamadı
            }

            var userRoles =await _userManager.GetRolesAsync(user);

            var userWithRoles = new
            {
                UserId = user.Id,
                Username = user.UserName,
                Roles = userRoles
            };

            return Ok(userWithRoles);

        }

        
        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult<User>> UserRegister(UserCreateDto userCreateDto)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    FirstName = userCreateDto.FirstName,
                    LastName = userCreateDto.LastName,
                    Email = userCreateDto.Email,
                    UserName = userCreateDto.UserName,

                };

                var result = await _userManager.CreateAsync(user, userCreateDto.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    return Ok("Kullanıcı başarıyla oluşturuldu.");
                }
                else
                {

                    return BadRequest();
                }
            }
            return BadRequest();



        }

        [HttpPost]
        [Route("api/tranieeRegister/")]
        public async Task<ActionResult<Trainee>> TranieeRegister(TranieeDto tranieeDto)
        {
            if (ModelState.IsValid)
            {
                Trainee user = new Trainee()
                {
                    FirstName = tranieeDto.FirstName,
                    LastName = tranieeDto.LastName,
                    Email = tranieeDto.Email,
                    UserName = tranieeDto.UserName,
                    Education = tranieeDto.Education

                };

                var result = await _userManager.CreateAsync(user, tranieeDto.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Traniee");
                    return Ok("Kullanıcı başarıyla oluşturuldu.");
                }
                else
                {

                    return BadRequest();
                }
            }
            return BadRequest();



        }
    }
}

