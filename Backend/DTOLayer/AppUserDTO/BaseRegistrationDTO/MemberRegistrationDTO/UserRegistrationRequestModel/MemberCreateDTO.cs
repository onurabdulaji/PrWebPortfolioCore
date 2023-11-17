using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.AppUserDTO.BaseRegistrationDTO.MemberRegistrationDTO.UserRegistrationRequestModel
{
    public class MemberCreateDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password Incorrect.")]
        public string ConfirmPassword { get; set; }
    }
}
