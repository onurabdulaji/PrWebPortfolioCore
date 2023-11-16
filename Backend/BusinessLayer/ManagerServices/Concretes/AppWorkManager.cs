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
    public class AppWorkManager : BaseManager<AppWork>, IAppWorkManager
    {
        IAppWorkRepository _appWorkRepository;

        public AppWorkManager(IAppWorkRepository appWorkRepository) : base(appWorkRepository)
        {
            _appWorkRepository = appWorkRepository;
        }
    }
}
