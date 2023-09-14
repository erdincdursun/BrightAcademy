using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Shared.DataTransferObject
{
    public class CategoryCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
