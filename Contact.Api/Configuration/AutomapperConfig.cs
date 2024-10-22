using AutoMapper;
using Contact.Api.DTO;
using Contact.Api.Models;


namespace Contact.Api.Configuration
{
    public class AutomapperConfig : Profile
    {

        public AutomapperConfig()
        {
            CreateMap<UserDTO, UserProfile>().ReverseMap();
            CreateMap<ContactDto, Models.Contact>().ReverseMap();
        }
    }
}
