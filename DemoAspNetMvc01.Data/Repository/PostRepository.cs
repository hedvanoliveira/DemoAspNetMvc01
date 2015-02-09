using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DemoAspNetMvc01.Data.Repository
{
    public class PostRepository:IPostRepository
    {
        private DataContext _context;

        public PostRepository(DataContext context)
        {
            _context = context;
        }

        public Post GetById(Guid id)
        {
            return _context.Posts.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Post> List()
        {
            return _context.Posts.ToList();
        }

        public void Create(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void Update(Post post)
        {
            _context.Entry<Post>(post).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
