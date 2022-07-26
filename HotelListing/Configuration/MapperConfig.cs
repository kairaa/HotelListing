using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.ApiUser;
using HotelListing.Models.Country;
using HotelListing.Models.Hotel;

namespace HotelListing.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, UpdateHotelDto>().ReverseMap();

            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
            CreateMap<ApiUser, GetApiUserDto>().ReverseMap();
            CreateMap<ApiUser, GetApiUserDetails>().ReverseMap();
        }
    }
}
