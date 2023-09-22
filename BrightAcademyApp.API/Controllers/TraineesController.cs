using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.ControllerBases;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrightAcademyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : CustomControllerBase
    {
        private readonly UserManager<IdentityUser> _traineeManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        


        public TraineesController(UserManager<IdentityUser> traineeManager, RoleManager<IdentityRole> roleManager, BrightAcademyAppDbContext dbContext)
        {
            _traineeManager = traineeManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("api/getAllTrainees/")]
        public async Task<IActionResult> GetAllTrainees()
        {

           var trainees= await _dbContext.Users.Where( u => EF.Property<string>(u, "Discriminator") == "Trainee").ToListAsync();
            return Ok(trainees);

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

                var result = await _traineeManager.CreateAsync(user, tranieeDto.Password);

                if (result.Succeeded)
                {
                    await _traineeManager.AddToRoleAsync(user, "Traniee");
                    return Ok("Öğrenci Kullanıcısı başarıyla oluşturuldu.");
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
