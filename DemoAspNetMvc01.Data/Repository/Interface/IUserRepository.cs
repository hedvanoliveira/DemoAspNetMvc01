using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Data.Repository.Interface
{
    public interface IUserRepository:IDisposable
    {
        User GetById(Guid id);

        IEnumerable<User> List();

        void Create(User user);
        void Update(User user);
        void Delete(User user);
    }
}
