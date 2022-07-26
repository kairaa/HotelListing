using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Hotel> GetDetails(int id)
        {
            return await _context.Hotels.Include(q => q.Country).Include(q => q.ApiUser)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
