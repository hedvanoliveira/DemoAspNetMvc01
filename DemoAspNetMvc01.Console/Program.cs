using DemoAspNetMvc01.Data;
using DemoAspNetMvc01.Data.Repository;
using DemoAspNetMvc01.Domain.Model;
using DemoAspNetMvc01.Service.Service;
using System;

namespace DemoAspNetMvc01.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var _userService = new PostService(new PostRepository(new DataContext()));


            User user1 = new User();
            user1.Id = Guid.NewGuid();
            user1.Name = "Admin";

            Category category1 = new Category();
            category1.Id = Guid.NewGuid();
            category1.Title = "Geral";

            Post post1 = new Post();
            post1.Id = Guid.NewGuid();
            post1.Title = "Meu primeiro post";
            post1.Description = "Um conteúdo interessante";
            post1.category = category1;
            post1.user = user1;

            _userService.Create(post1);

        }
    }
}
