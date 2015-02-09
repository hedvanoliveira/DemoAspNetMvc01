using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Data.Repository.Interface
{
    public interface IPostRepository:IDisposable
    {
        Post GetById(Guid id);

        IEnumerable<Post> List();

        void Create(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
