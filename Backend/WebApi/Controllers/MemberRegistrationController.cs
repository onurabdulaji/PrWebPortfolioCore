using AutoMapper;
using BusinessLayer.ManagerServices.Absracts;
using DTOLayer.AppUserDTO.BaseRegistrationDTO.MemberRegistrationDTO.UserRegistrationRequestModel;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberRegistrationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAppUserManager _userManager;

        public MemberRegistrationController(IMapper mapper, IAppUserManager userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> MemberRegisterUser([FromBody] MemberCreateDTO memberCreateDTO)
        {
            var appUser = _mapper.Map<AppUser>(memberCreateDTO); // MemberCreateDTO'yu AppUser sınıfına dönüştürme
            var createdUser = await _userManager.TRegisterMemberAsync(appUser);
            if (createdUser)
            {
                return Ok("Kullanıcı ekleme basarılı");
            }
            return BadRequest("Kullanıcı ekleme kısmında bir sorunla karsılasıldı");
        }
    }
}
