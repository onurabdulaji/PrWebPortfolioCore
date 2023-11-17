using BusinessLayer.ManagerServices.Absracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserMemberController : ControllerBase
    {
        private readonly IAppUserManager _appUserManager;

        public AppUserMemberController(IAppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }

        [HttpGet]
        public IActionResult GetAllAppUser()
        {
            var values = _appUserManager.TGetList();
            return Ok(values);
        }
    }
}
