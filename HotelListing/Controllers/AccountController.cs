using AutoMapper;
using HotelListing.Contracts;
using HotelListing.Models.ApiUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager _authManager;
        private readonly IMapper _mapper;
        private readonly IApiUsersRepository _apiUsersRepository;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IAuthManager authManager, IMapper mapper, IApiUsersRepository apiUsersRepository, ILogger<AccountController> logger)
        {
            this._authManager = authManager;
            this._mapper = mapper;
            this._apiUsersRepository = apiUsersRepository;
            this._logger = logger;
        }

        // api/Account/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            _logger.LogInformation($"Registiration attemp for {apiUserDto.UserName}");

            var errors = await _authManager.Register(apiUserDto);

            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
        {
            _logger.LogInformation($"Login attemp for {loginDto.UserName}");

            var authResponse = await _authManager.Login(loginDto);

            if (authResponse == null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }

        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RefreshToken([FromBody] AuthResponseDto request)
        {
            var authResponse = await _authManager.VerifyRefreshToken(request);

            if (authResponse == null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }

        // GET: api/Countries
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<IEnumerable<GetApiUserDto>>> GetApiUsers()
        {
            var apiUsers = await _apiUsersRepository.GetAllAsync();
            var apiUsersDto = _mapper.Map<List<GetApiUserDto>>(apiUsers);
            return Ok(apiUsersDto);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<GetApiUserDetails>> GetApiUser(string id)
        {
            var apiUser = await _apiUsersRepository.GetDetails(id);

            if (apiUser == null)
            {
                return NotFound();
            }

            var apiUserDto = _mapper.Map<GetApiUserDetails>(apiUser);

            return Ok(apiUserDto);
        }
    }
}
