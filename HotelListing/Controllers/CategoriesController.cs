using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.Data;
using HotelListing.Models.Country;
using AutoMapper;
using HotelListing.Contracts;
using Microsoft.AspNetCore.Authorization;
using HotelListing.Exceptions;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(IMapper mapper, ICategoriesRepository categoriesRepository, ILogger<CategoriesController> logger)
        {
            _mapper = mapper;
            _categoriesRepository = categoriesRepository;
            this._logger = logger;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCategoryDto>>> GetCategories()
        {
            var categories = await _categoriesRepository.GetAllAsync();
            var categoriesDto = _mapper.Map<List<GetCategoryDto>>(categories);
            return Ok(categoriesDto);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var category = await _categoriesRepository.GetDetails(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(GetCategory), id);
            }

            var categoryDto = _mapper.Map<CategoryDto>(category);

            return Ok(categoryDto);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles ="Administrator, User")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, UpdateCategoryDto updateCategoryDto)
        {
            if (id != updateCategoryDto.Id)
            {
                throw new BadRequestException("Invalid record Id");
            }

            //_context.Entry(country).State = EntityState.Modified;
            var category = await _categoriesRepository.GetAsync(id);

            if (category == null)
            {
                throw new NotFoundException(nameof(PutCategory), id);
            }

            _mapper.Map(updateCategoryDto, category);

            try
            {
                await _categoriesRepository.UpdateAsync(category);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CategoryExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Administrator, User")]
        public async Task<ActionResult<Category>> PostCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);

            await _categoriesRepository.AddAsync(category);

            return CreatedAtAction("GetCountry", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _categoriesRepository.GetAsync(id);
            if (category == null)
            {
                throw new NotFoundException(nameof(DeleteCategory), id);
            }

            await _categoriesRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CategoryExists(int id)
        {
            return await _categoriesRepository.Exist(id);
        }
    }
}
