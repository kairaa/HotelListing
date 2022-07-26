using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    ApiUserId = "ba073dce-0416-40d9-8a9c-e9372435c3f1",
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    ApiUserId = "ba073dce-0416-40d9-8a9c-e9372435c3f1",
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    ApiUserId = "e2e74b3c-d858-4934-b76e-3df438f5fcba",
                    Rating = 4
                }
                );
        }
    }
}
