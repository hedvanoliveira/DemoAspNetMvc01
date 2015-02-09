using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Service.Service.Interface
{
    public interface IPostService:IDisposable
    {
        Post GetById(Guid id);

        IEnumerable<Post> List();

        void Create(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
