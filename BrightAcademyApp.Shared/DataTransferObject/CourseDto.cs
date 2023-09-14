using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Shared.DataTransferObject
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseHours { get; set; }
        public int EducationTime { get; set; }
        public DateTime EducationStartTime { get; set; } = DateTime.Now;
        public DateTime EducationFinishTime { get; set; } = DateTime.Now;
        public string EducationLevel { get; set; }
        public string EducationGains { get; set; }
        public string EducationType { get; set; }
        public string EducationTitle { get; set; }
        public string EducationEvaluation { get; set; }
        public bool EducationStatus { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<TranieeDto> Traniees { get; set; }
        public List<TranierDto> Traniners { get; set; }
    }
}
