using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.ApiUser
{
    public class ApiUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "Your password is limited to 7 to 16")]
        public string Password { get; set; }
    }
}
