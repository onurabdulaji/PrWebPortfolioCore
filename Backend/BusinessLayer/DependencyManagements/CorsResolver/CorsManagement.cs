using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyManagements.CorsResolver
{
    public static class CorsManagement
    {
        public static IServiceCollection CorseResolver(this IServiceCollection services)
        {
            return services;
        }
    }
}
