using HotelListing.Data;
using HotelListing.Models.Hotel;

namespace HotelListing.Models.Country
{
    public class CategoryDto : BaseCategoryDto
    {
        public int Id { get; set; }
        public virtual IList<GetPostDto> Posts { get; set; }
    }
}
