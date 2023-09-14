﻿using AutoMapper;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)
        {
            var newCategory = _mapper.Map<Category>(categoryCreateDto);
            await _categoryRepository.CreateAsync(newCategory);
            return Response<CategoryDto>.Success(_mapper.Map<CategoryDto>(newCategory), 201);
        }

        public Task<Response<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            var categoryList = await _categoryRepository.GetAllAsync();
            if (categoryList == null)
            {
                return Response<List<CategoryDto>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDtoList = _mapper.Map<List<CategoryDto>>(categoryList);
            return Response<List<CategoryDto>>.Success(categoryDtoList, 200);
        }

        public async Task<Response<CategoryDto>> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<CategoryDto>.Fail("Böyle bir kategori yok!", 301);
            }
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return Response<CategoryDto>.Success(categoryDto, 200);
        }

        public Response<NoContent> Update(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
