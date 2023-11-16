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
    public class AppAboutManager : BaseManager<AppAbout>, IAppAboutManager
    {
        IAppAboutRepository _appAboutRepository; // Burada alir DAL'daki Interface'i Entity icin.

        public AppAboutManager(IAppAboutRepository appAboutRepository) : base(appAboutRepository)
        {
            _appAboutRepository = appAboutRepository;
        }
    }
}
