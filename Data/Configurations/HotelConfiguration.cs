using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
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
                    Adress = "Negril",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Adress = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Adress = "Nssua",
                    CountryId = 1,
                    Rating = 4
                }
                );
        }
    }
}
