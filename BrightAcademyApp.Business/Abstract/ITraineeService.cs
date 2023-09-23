using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Abstract
{
    public interface ITraineeService
    {
        Task<List<IdentityUser>> GetAllTrainees();

    }
}
