using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Context { get; set; }
        public DateTime PostDate { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey(nameof(ApiUserId))]
        public string ApiUserId { get; set; }
        public ApiUser ApiUser { get; set; }
    }
}
