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
    public class AppMyClientManager : BaseManager<AppMyClient>, IAppMyClientManager
    {
        IAppMyClientRepository _appMyClientRepository;

        public AppMyClientManager(IAppMyClientRepository appMyClientRepository) : base(appMyClientRepository)
        {
            _appMyClientRepository = appMyClientRepository;
        }
    }
}
