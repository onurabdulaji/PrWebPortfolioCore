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
    public class AppRoleManager : BaseManager<AppRole>, IAppRoleManager
    {
        IAppRoleRepository _appRoleRepository;

        public AppRoleManager(IAppRoleRepository appRoleRepository) : base(appRoleRepository)
        {
            _appRoleRepository = appRoleRepository;
        }
    }
}
