using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Hotel
{
    public class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public string ApiUserId { get; set; }
    }
}
