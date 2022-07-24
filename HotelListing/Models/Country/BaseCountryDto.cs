using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Country
{
    public class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }
    }
}
