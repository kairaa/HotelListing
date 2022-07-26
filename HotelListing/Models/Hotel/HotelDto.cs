using HotelListing.Models.ApiUser;
using HotelListing.Models.Country;

namespace HotelListing.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
        public GetCountryDto Country { get; set; }
        public GetApiUserDto ApiUser { get; set; }
    }
}
