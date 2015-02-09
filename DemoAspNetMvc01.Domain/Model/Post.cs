using System;

namespace DemoAspNetMvc01.Domain.Model
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid CategoryId { get; set; }

        public Guid UserId { get; set; }

        public virtual User user { get; set; }

        public virtual Category category{ get; set; }
    }
}
