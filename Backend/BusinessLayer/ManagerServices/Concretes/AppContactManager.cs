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
    public class AppContactManager : BaseManager<AppContact>, IAppContactManager
    {
        IAppContactRepository _appContactRepository;

        public AppContactManager(IAppContactRepository appContactRepository) : base(appContactRepository)
        {
            _appContactRepository = appContactRepository;
        }
    }
}
