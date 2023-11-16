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
    public class AppServiceManager : BaseManager<AppService>, IAppServiceManager
    {
        IAppServiceRepository _appServiceRepository;

        public AppServiceManager(IAppServiceRepository appServiceRepository) : base(appServiceRepository)
        {
            _appServiceRepository = appServiceRepository;
        }
    }
}
