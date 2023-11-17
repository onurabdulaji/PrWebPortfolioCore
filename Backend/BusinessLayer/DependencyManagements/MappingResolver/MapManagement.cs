using EntityLayer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyManagements.MappingResolver
{
    public static class MapManagement
    {
        public static IServiceCollection MappingResolver(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppUser));
            return services;
        }
    }
}
