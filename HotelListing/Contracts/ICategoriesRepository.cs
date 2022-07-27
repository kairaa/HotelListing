using HotelListing.Data;

namespace HotelListing.Contracts
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Task<Category> GetDetails(int id);
    }
}
