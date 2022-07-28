using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class PostsRepository : GenericRepository<Post>, IPostsRepository
    {
        private readonly HotelListingDbContext _context;

        public PostsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAllPostReverse()
        {
            return await _context.Set<Post>().OrderByDescending(q => q.PostDate).ToListAsync();
        }

        public async Task<Post> GetDetails(int id)
        {
            return await _context.Posts.Include(q => q.Category).Include(q => q.ApiUser)
                .FirstOrDefaultAsync(q => q.Id == id);
            //return await _context.Hotels.Include(q => q.Country).Include(q => q.ApiUser)
            //    .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
