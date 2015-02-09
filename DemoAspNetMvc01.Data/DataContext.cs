using DemoAspNetMvc01.Data.Map;
using DemoAspNetMvc01.Domain.Model;
using System.Data.Entity;

namespace DemoAspNetMvc01.Data
{
    public class DataContext:DbContext
    {
        public DataContext()
            : base("DemoAspNetMvcDbLocalDb")//DemoAspNetMvcDbSqlServer DemoAspNetMvcDbLocalDb
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new PostMap());

            modelBuilder.Entity<Post>().HasRequired(x => x.category)
            .WithMany(x => x.posts)
            .HasForeignKey(c => c.CategoryId)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>().HasRequired(x => x.user)
           .WithMany(x => x.posts)
           .HasForeignKey(c => c.UserId)
           .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }

    }
}
