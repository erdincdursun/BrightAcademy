﻿using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Abstract
{
    public interface ITrainerRepository : IGenericRepository<IdentityUser>
    {
        Task<List<IdentityUser>> GetAllTrainers();
    }
}
