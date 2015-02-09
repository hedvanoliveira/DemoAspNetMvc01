using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Service.Service.Interface
{
    public interface ICategoryService:IDisposable
    {
        Category GetById(Guid id);

        IEnumerable<Category> List();

        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
