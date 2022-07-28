using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.Data;
using AutoMapper;
using HotelListing.Contracts;
using HotelListing.Models.Hotel;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPostsRepository _postsRepository;

        public PostsController(IPostsRepository postsRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postsRepository = postsRepository;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetPostDto>>> GetPosts()
        {
            var posts = await _postsRepository.GetAllPostReverse();
            var postsDto = _mapper.Map<List<GetPostDto>>(posts);
            return Ok(postsDto);
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPost(int id)
        {
            var post = await _postsRepository.GetDetails(id);

            if (post == null)
            {
                return NotFound();
            }

            var psotDto = _mapper.Map<PostDto>(post);

            return Ok(psotDto);
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, UpdatePostDto updatePostDto)
        {
            if (id != updatePostDto.Id)
            {
                return BadRequest();
            }

            var post = await _postsRepository.GetAsync(id);

            if(post == null)
            {
                return NotFound();
            }

            _mapper.Map(updatePostDto, post);

            try
            {
                await _postsRepository.UpdateAsync(post);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PostExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(CreatePostDto createPostDto)
        {
            var post = _mapper.Map<Post>(createPostDto);

            await _postsRepository.AddAsync(post);

            return CreatedAtAction("GetHotel", new { id = post.Id }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _postsRepository.GetAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            await _postsRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PostExist(int id)
        {
            return await _postsRepository.Exist(id);
        }
    }
}
