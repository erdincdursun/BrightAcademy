﻿using BrightAcademyApp.Data.Abstract;
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
        public EfCoreTrainerRepository(BrightAcademyAppDbContext dbContext) : base(dbContext)
        {
        }
        private BrightAcademyAppDbContext Context
        {
            get { return _dbContext as BrightAcademyAppDbContext; }
        }

        public Task CreateAsync(IdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IdentityUser entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IdentityUser>> GetAllTrainers()
        {

            var trainers = await Context.Users.Where(u => EF.Property<string>(u, "Discriminator") == "Trainer").ToListAsync();
            return trainers;

        }

        public void Update(IdentityUser entity)
        {
            throw new NotImplementedException();
        }

        Task<List<IdentityUser>> IGenericRepository<IdentityUser>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<IdentityUser> IGenericRepository<IdentityUser>.GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
