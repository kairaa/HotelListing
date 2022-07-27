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
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<Post, GetPostDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Post, UpdatePostDto>().ReverseMap();

            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
            CreateMap<ApiUser, GetApiUserDto>().ReverseMap();
            CreateMap<ApiUser, GetApiUserDetails>().ReverseMap();
        }
    }
}
