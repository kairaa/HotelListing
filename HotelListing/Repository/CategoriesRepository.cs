using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CategoriesRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Category> GetDetails(int id)
        {
            //throw new NotImplementedException();
            return await _context.Categories.Include(q => q.Posts)
                .FirstOrDefaultAsync(q => q.Id == id);
            //return await _context.Countries.Include(q => q.Hotels).
            //    FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
