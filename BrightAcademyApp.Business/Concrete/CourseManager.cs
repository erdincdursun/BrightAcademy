using AutoMapper;
using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseManager(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto)
        {
            var newCourse = _mapper.Map<Course>(courseCreateDto);
            await _courseRepository.CreateAsync(newCourse);
            return Response<CourseDto>.Success(_mapper.Map<CourseDto>(newCourse), 201);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedCourse = await _courseRepository.GetByIdAsync(id);
            if (deletedCourse == null) return Response<NoContent>.Fail("Böyle bir kurs yok", 401);
            _courseRepository.Delete(deletedCourse);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<CourseDto>>> GetAllAsync()
        {
            var courseList = await _courseRepository.GetAllAsync();
            if (courseList != null)
            {
                var courseDtoList = _mapper.Map<List<CourseDto>>(courseList);
                return Response<List<CourseDto>>.Success(courseDtoList, 200);
            }
                       
            return Response<List<CourseDto>>.Fail("Kayıtlı kurs bulunamadı", 401);
        }

        public async Task<Response<List<CourseDto>>> GetCoursesFullDataAsync(bool? isActive = null)
        {
            var courseList = await _courseRepository.GetCoursesFullDataAsync(isActive);
            if (courseList.Any())
            {
                var courseDtoList = _mapper.Map<List<CourseDto>>(courseList);
                return Response<List<CourseDto>>.Success(courseDtoList, 200);
            }
            return Response<List<CourseDto>>.Fail("Kayıtlı course bulunamadı", 401);
        }

        public async Task<Response<CourseDto>> GetByIdAsync(int? id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course != null)
            {
                var courseDto = _mapper.Map<CourseDto>(course); 
                return Response<CourseDto>.Success(courseDto,200);
            }
            return Response<CourseDto>.Fail("Kurs bulunamadı." , 401);
            
        }

        public async Task<Response<CourseDto>> GetCourseByIdAsync(int id)
        {
            var course = await _courseRepository.GetCourseByIdAsync(id);
            if (course != null)
            {
                var courseDto = _mapper.Map<CourseDto>(course);
                return Response<CourseDto>.Success(courseDto, 200);
            }
            return Response<CourseDto>.Fail("Kurs bulunamadı.", 401);
        }

        public async Task<Response<NoContent>> UpdateAsync(int id, CourseDto courseDto)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course is null) return Response<NoContent>.Fail("Böyle bir kurs yok", 401);

            //Mapping
            var courseUpdate = _mapper.Map<Course>(courseDto);
            _courseRepository.Update(courseUpdate);
            return Response<NoContent>.Success(204);
        }
    }
}
