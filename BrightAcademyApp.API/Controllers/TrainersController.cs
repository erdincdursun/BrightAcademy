using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.ControllerBases;
using BrightAcademyApp.Shared.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrightAcademyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : CustomControllerBase
    {
       private readonly UserManager<IdentityUser> _userManager;
        private readonly ITrainerService _trainerService;

        public TrainersController(UserManager<IdentityUser> userManager, ITrainerService trainerService)
        {
            _userManager = userManager;
            _trainerService = trainerService;
        }

        [HttpGet]
        [Route("api/getAllTrainers/")]
        public async Task<IActionResult> GetAllTrainers()
        {
            var trainers = await _trainerService.GetAllTrainers();
            return Ok(trainers);

        }

        [HttpPost]
        [Route("api/tranierRegister/")]
        public async Task<ActionResult<Trainer>> TranierRegister(TranierDto tranierDto)
        {
            if (ModelState.IsValid)
            {
                Trainer user = new Trainer()
                {
                    FirstName = tranierDto.FirstName,
                    LastName = tranierDto.LastName,
                    Email = tranierDto.Email,
                    UserName = tranierDto.UserName,
                    Education = tranierDto.Education,
                    Branch = tranierDto.Branch
                };

                var result = await _userManager.CreateAsync(user, tranierDto.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Tranier");
                    return Ok("Eğitmen Kullanıcısı başarıyla oluşturuldu.");
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
