using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Domain.Model
{
    public class User
    {
        public User()
        {
            this.posts = new List<Post>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Post> posts { get; set; }
    }
}
