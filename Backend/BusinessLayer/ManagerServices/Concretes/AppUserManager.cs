using BusinessLayer.ManagerServices.Absracts;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository) : base(appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public async Task<bool> TRegisterMemberAsync(AppUser item, string Password)
        {
            if (item.Email == null && item.UserName == null && Password == null)
            {
                return false;
            }
            else
            {
                var result = await _appUserRepository.RegisterMemberAsync(item, Password);
                return result;
            }
        }
    }
}
