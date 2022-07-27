using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post
                {
                    Id = 1,
                    Context = "This is first post in database",
                    Title = "Title of first post",
                    PostDate = DateTime.Now,
                    ApiUserId = "ba073dce-0416-40d9-8a9c-e9372435c3f1",
                    CategoryId = 1,
                },
                new Post
                {
                    Id = 2,
                    Context = "This is second post of kairaa in database",
                    Title = "Title of second post of kaira",
                    PostDate = DateTime.Now,
                    ApiUserId = "ba073dce-0416-40d9-8a9c-e9372435c3f1",
                    CategoryId = 2,
                },
                new Post
                {
                    Id = 3,
                    Context = "This is first post of ulas in database",
                    Title = "Title of first post of ulas",
                    PostDate = DateTime.Now,
                    ApiUserId = "e2e74b3c-d858-4934-b76e-3df438f5fcba",
                    CategoryId = 1
                }
                );
        }
    }
}
