
using Microsoft.AspNetCore.Identity;


namespace BrightAcademyApp.Entity.Concrete
{
    public class Trainee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<CourseTrainee> CourseTraniees { get; set; }


    }
}
