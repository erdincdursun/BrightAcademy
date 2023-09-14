using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Shared.DataTransferObject
{
    public class CourseCreateDto
    {
        public string Name { get; set; }
        public int CourseHours { get; set; }
        public int EducationTime { get; set; }
        public DateTime EducationStartTime { get; set; } 
        public DateTime EducationFinishTime { get; set; } 
        public string EducationLevel { get; set; }
        public string EducationGains { get; set; }
        public string EducationType { get; set; }
        public string EducationTitle { get; set; }
        public string EducationEvaluation { get; set; }
        public bool EducationStatus { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
