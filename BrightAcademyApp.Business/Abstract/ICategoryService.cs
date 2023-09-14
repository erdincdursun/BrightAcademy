using BrightAcademyApp.Entity.Concrete;
using BrightAcademyApp.Shared.DataTransferObject;
using BrightAcademyApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademyApp.Business.Abstract
{
    public interface ICategoryService
    {
        Task<Response<CategoryDto>> GetByIdAsync(int id);
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);
        Response<NoContent> Update(CategoryDto categoryDto);
        Task<Response<NoContent>> Delete(int id);
    }
}
