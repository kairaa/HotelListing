using HotelListing.Data;

namespace HotelListing.Contracts
{
    public interface IPostsRepository : IGenericRepository<Post>
    {
        Task<Post> GetDetails(int id);
    }
}
