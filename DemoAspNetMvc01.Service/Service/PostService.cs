using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Domain.Model;
using DemoAspNetMvc01.Service.Service.Interface;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Service.Service
{
    public class PostService:IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Post GetById(Guid id)
        {
            return _postRepository.GetById(id);
        }

        public IEnumerable<Post> List()
        {
            return _postRepository.List();
        }

        public void Create(Post post)
        {
            _postRepository.Create(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public void Delete(Post post)
        {
            _postRepository.Delete(post);
        }

        public void Dispose()
        {
            _postRepository.Dispose();
        }
    }
}
