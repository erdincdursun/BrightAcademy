using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCoreTraineeRepository : EfCoreGenericRepository<Trainee>, ITraineeRepository
    {
        public EfCoreTraineeRepository(BrightAcademyAppDbContext _context) : base(_context)
        {
        }
        private BrightAcademyAppDbContext Context
        {
            get { return _dbContext as BrightAcademyAppDbContext; }
        }
        public Task CreateAsync(Trainee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Trainee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IdentityUser>> GetAllTrainees()
        {
            var trainees = await Context.Users.Where(u => EF.Property<string>(u, "Discriminator") == "Trainee").ToListAsync();
            return trainees;
        }

        public void Update(Trainee entity)
        {
            throw new NotImplementedException();
        }

        Task<List<Trainee>> IGenericRepository<Trainee>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Trainee> IGenericRepository<Trainee>.GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
