using BrightAcademyApp.Business.Abstract;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITraineeService _traineeManager;

        public TraineesController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITraineeService traineeManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _traineeManager = traineeManager;
        }

        #region AllTrainees
        [HttpGet]
        [Route("api/getAllTrainees/")]
        public async Task<IActionResult> GetAllTrainees()
        {

            var trainees = await _traineeManager.GetAllTrainees();
            return Ok(trainees);

        }
        #endregion
        #region RegisterTrainee
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
                    return Ok("Öğrenci Kullanıcısı başarıyla oluşturuldu.");
                }
                else
                {

                    return BadRequest();
                }
            }
            return BadRequest();



        }
        #endregion




    }
}
