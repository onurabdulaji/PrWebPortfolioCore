﻿using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concretes
{
    public class AppTestimonialRepository : BaseRepository<AppTestimonial>, IAppTestimonialRepository
    {
        public AppTestimonialRepository(MyContext db) : base(db)
        {
        }
    }
}
