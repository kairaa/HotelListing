using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Hotel
{
    public class BasePostDto
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Context { get; set; }
        [Required]
        public DateTime PostDate { get; set; }
        [Required]
        public string ApiUserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
