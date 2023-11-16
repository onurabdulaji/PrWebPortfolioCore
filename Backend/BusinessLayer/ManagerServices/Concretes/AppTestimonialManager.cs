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
    public class AppTestimonialManager : BaseManager<AppTestimonial>, IAppTestimonialManager
    {
        IAppTestimonialRepository _appTestimonialRepository;

        public AppTestimonialManager(IAppTestimonialRepository appTestimonialRepository) : base(appTestimonialRepository)
        {
            _appTestimonialRepository = appTestimonialRepository;
        }
    }
}
