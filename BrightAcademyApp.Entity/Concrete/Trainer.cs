using BrightAcademyApp.Entity.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Entity.Concrete
{
    public class Trainer : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public bool IsActive { get; set; }
        public string Branch { get; set; }
        public string InstructorExperience { get; set; }
        public int InstructorPoints { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<CourseTrainer> CourseTraniners { get; set; }



    }
}
