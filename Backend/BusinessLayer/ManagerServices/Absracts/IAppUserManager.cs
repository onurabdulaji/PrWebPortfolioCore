using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Absracts
{
    public interface IAppUserManager : IManager<AppUser>
    {
        Task<bool> TRegisterMemberAsync(AppUser item, string Password);
    }
}
