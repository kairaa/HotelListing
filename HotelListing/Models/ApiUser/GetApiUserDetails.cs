﻿using HotelListing.Models.Hotel;

namespace HotelListing.Models.ApiUser
{
    public class GetApiUserDetails : BaseApiUserDto
    {
        public string Id { get; set; }
        public virtual IList<GetHotelDto> Hotels { get; set; }
    }
}
