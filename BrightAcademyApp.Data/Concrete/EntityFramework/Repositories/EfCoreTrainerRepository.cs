using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Repositories
{
    internal class EfCoreTrainerRepository : EfCoreGenericRepository<Trainer>, ITrainerRepository
    {
        public EfCoreTrainerRepository(DbContext dbContext) : base(dbContext)
        {
        }
        private BrightAcademyAppDbContext Context
        {
            get { return _dbContext as BrightAcademyAppDbContext; }
        }
        public async Task<List<IdentityUser>> GetAllTrainers()
        {

            var trainees = await Context.Users.Where(u => EF.Property<string>(u, "Discriminator") == "Trainee").ToListAsync();
            return trainees;

        }
    }
}
