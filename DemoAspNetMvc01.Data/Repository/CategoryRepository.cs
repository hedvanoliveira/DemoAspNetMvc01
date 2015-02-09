using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DemoAspNetMvc01.Data.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public Category GetById(Guid id)
        {
            return _context.Categories.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Category> List()
        {
            return _context.Categories.ToList();
        }

        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Entry<Category>(category).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
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
