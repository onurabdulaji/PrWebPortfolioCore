using AutoMapper;
using DTOLayer.AppUserDTO.BaseRegistrationDTO.MemberRegistrationDTO.UserRegistrationRequestModel;
using EntityLayer.Models;

namespace MVCUI.Mapping
{
    public class AutoMapperUIConfig : Profile
    {
        public AutoMapperUIConfig()
        {
            CreateMap<MemberCreateDTO, AppUser>();
        }
    }
}
