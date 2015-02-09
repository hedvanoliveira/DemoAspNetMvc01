using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Domain.Model;
using DemoAspNetMvc01.Service.Service.Interface;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Service.Service
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category GetById(Guid id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> List()
        {
            return _categoryRepository.List();
        }

        public void Create(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public void Dispose()
        {
            _categoryRepository.Dispose();
        }
    }
}
