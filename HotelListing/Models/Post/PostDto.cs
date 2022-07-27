using HotelListing.Models.ApiUser;
using HotelListing.Models.Country;

namespace HotelListing.Models.Hotel
{
    public class PostDto : BasePostDto
    {
        public int Id { get; set; }
        public GetCategoryDto Category { get; set; }
        public GetApiUserDto ApiUser { get; set; }
    }
}
