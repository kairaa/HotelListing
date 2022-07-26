using HotelListing.Data;

namespace HotelListing.Contracts
{
    public interface IApiUsersRepository : IGenericRepository<ApiUser>
    {
        Task<ApiUser> GetDetails(string id);
    }
}
