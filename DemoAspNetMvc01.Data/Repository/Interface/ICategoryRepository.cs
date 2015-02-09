using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Data.Repository.Interface
{
    public interface ICategoryRepository:IDisposable
    {
        Category GetById(Guid id);

        IEnumerable<Category> List();

        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);

    }
}
