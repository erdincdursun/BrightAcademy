using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Concrete
{
    public class TrainerManager : ITrainerService
    {
        private ITrainerRepository _trainerRepository;

        public TrainerManager(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public async Task<List<IdentityUser>> GetAllTrainers()
        {
            var trainees = await _trainerRepository.GetAllTrainers();
            return trainees;
        }
    }
}
