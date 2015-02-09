using DemoAspNetMvc01.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DemoAspNetMvc01.Data.Map
{
    public class PostMap:EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Title)
                .HasColumnType("varchar")
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Description)
                .HasColumnType("varchar")
                .IsRequired();

           
        }
    }
}
