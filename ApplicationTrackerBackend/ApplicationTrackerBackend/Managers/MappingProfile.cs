using AutoMapper;
using ApplicationTrackerBackend.DataTransferObjects;
using ApplicationTrackerBackend.Models;

namespace ApplicationTrackerBackend.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
