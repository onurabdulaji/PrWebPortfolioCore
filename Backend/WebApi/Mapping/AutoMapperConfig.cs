using AutoMapper;
using DTOLayer.AppUserDTO.BaseRegistrationDTO.MemberRegistrationDTO.UserRegistrationRequestModel;
using EntityLayer.Models;

namespace WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<MemberCreateDTO, AppUser>()
             .ForMember(u => u.FirstName, opt => opt.MapFrom(x => x.Name))
             .ForMember(u => u.LastName, opt => opt.MapFrom(x => x.Surname))
             .ForMember(u => u.Email, opt => opt.MapFrom(x => x.Mail))
             .ForMember(u => u.PasswordHash, opt => opt.MapFrom(x => x.Password))
             .ReverseMap();
        }
    }
}
