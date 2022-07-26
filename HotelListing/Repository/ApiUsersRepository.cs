using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class ApiUsersRepository : GenericRepository<ApiUser>, IApiUsersRepository
    {
        private readonly HotelListingDbContext _context;

        public ApiUsersRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<ApiUser> GetDetails(string id)
        {
            return await _context.Users.Include(q => q.Hotels).
                FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
