using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Domain.Model
{
    public class Category
    {
        public Category()
        {
            this.posts = new List<Post>();
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Post> posts { get; set; }
    }
}
