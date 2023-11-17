﻿using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;
        public AppUserRepository(MyContext db, UserManager<AppUser> userManager) : base(db)
        {
            _userManager = userManager;
        }

        public async Task<bool> RegisterMemberAsync(AppUser item, string Password)
        {
            IdentityResult registerMemberUser = await _userManager.CreateAsync(item, Password);
            if (registerMemberUser.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
