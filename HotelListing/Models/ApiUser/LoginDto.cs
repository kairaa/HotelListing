using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.ApiUser
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "Your password is limited to 7 to 16")]
        public string Password { get; set; }
    }
}
