using AutoMapper;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;


namespace BrightAcademyApp.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();

            CreateMap<Trainee, TranieeDto>().ReverseMap();
            CreateMap<Trainer, TranierDto>().ReverseMap();
            
            CreateMap<Course, CourseDto>()
             .ForMember(x => x.Categories, opt => opt.MapFrom(x => x.CourseCategories.Select(x => x.Category)))
             .ForMember(x => x.Traniees, opt => opt.MapFrom(x => x.CourseTraniees.Select(x => x.Trainee)))
             .ForMember(x => x.Traniners, opt => opt.MapFrom(x => x.CourseTraniners.Select(x => x.Trainer)))
             .ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();


        }
    }
}
