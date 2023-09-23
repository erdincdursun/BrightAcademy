using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Data.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Concrete
{
    public class TranieeManager : ITraineeService
    {
        private readonly ITraineeRepository _traineeRepository;

        public TranieeManager(ITraineeRepository traineeRepository)
        {
            _traineeRepository = traineeRepository;
        }

        public async Task<List<IdentityUser>> GetAllTrainees()
        {
            var trainees = await _traineeRepository.GetAllTrainees();
            return trainees;
        }
    }
}
