using DTOLayer.AppUserDTO.BaseRegistrationDTO.MemberRegistrationDTO.UserRegistrationRequestModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Web.Http.ModelBinding;

namespace MVCUI.Controllers
{
    public class MemberRegisterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MemberRegisterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberCreateDTO memberCreateDTO)
        {
            return View(memberCreateDTO);
        }
    }
}




//if (!ModelState.IsValid)
//{
//    return View(memberCreateDTO);
//}
//try
//{
//    var json = JsonConvert.SerializeObject(memberCreateDTO);
//    var content = new StringContent(json, Encoding.UTF8, "application/json");
//    var client = _httpClientFactory.CreateClient();
//    var response = await client.PostAsync("https://localhost:44327/api/MemberRegistration", content);
//    if (response.IsSuccessStatusCode)
//    {
//        return RedirectToAction("SignIn", "Login");
//    }
//    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
//    {
//        ModelState.AddModelError(string.Empty, "Üye kaydı başarısız. Lütfen tekrar deneyin.");
//        return View(memberCreateDTO);
//    }
//    else
//    {
//        ModelState.AddModelError(string.Empty, "Üye kaydı sırasında bir hata oluştu.");
//        return View(memberCreateDTO);
//    }

//}
//catch (HttpRequestException ex)
//{
//    ModelState.AddModelError(string.Empty, $"API'ye istek yapılırken hata oluştu: {ex.Message}");
//    return View(memberCreateDTO);
//}