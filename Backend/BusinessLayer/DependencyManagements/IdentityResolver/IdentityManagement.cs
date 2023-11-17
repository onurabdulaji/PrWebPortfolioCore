using DataAccessLayer.Context;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyManagements.IdentityResolver
{
    public static class IdentityManagement
    {
        public static IServiceCollection IdentityResolver(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<MyContext>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider)
                .AddEntityFrameworkStores<MyContext>();

            services.AddIdentityCore<AppUser>
                (opt => opt.SignIn.RequireConfirmedEmail = true)
                .AddEntityFrameworkStores<MyContext>();

            return services;
        }
    }
}
