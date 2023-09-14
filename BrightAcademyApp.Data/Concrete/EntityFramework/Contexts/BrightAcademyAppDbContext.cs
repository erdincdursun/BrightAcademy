using BrightAcademyApp.Data.Concrete.EntityFramework.Configs;
using BrightAcademyApp.Data.Concrete.EntityFramework.Extensions;
using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Data.Concrete.EntityFramework.Contexts
{
    public class BrightAcademyAppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public BrightAcademyAppDbContext(DbContextOptions<BrightAcademyAppDbContext> options) : base(options)
        {
        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseTrainee> CourseTrainees { get; set; }
        public DbSet<CourseTrainer> CourseTrainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
