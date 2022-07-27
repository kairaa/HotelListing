using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Test"
                },
                new Category
                {
                    Id = 2,
                    Name = "Comedy"
                },
                new Category
                {
                    Id = 3,
                    Name = "Problem"
                }
                );
        }
    }
}
