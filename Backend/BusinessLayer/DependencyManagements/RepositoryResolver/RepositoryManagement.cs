using BusinessLayer.ManagerServices.Absracts;
using BusinessLayer.ManagerServices.Concretes;
using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyManagements.RepositoryResolver
{
    public static class RepositoryManagement
    {
        public static IServiceCollection RepositoriesResolver(this IServiceCollection services)
        {
            // Bases

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            // Base Dependencies 

            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();

            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppRoleRepository, AppRoleRepository>();

            services.AddScoped<IAppAboutManager, AppAboutManager>();
            services.AddScoped<IAppAboutRepository, AppAboutRepository>();

            services.AddScoped<IAppContactManager, AppContactManager>();
            services.AddScoped<IAppContactRepository, AppContactRepository>();

            services.AddScoped<IAppMyClientManager, AppMyClientManager>();
            services.AddScoped<IAppMyClientRepository, AppMyClientRepository>();

            services.AddScoped<IAppServiceManager, AppServiceManager>();
            services.AddScoped<IAppServiceRepository, AppServiceRepository>();

            services.AddScoped<IAppTestimonialManager, AppTestimonialManager>();
            services.AddScoped<IAppTestimonialRepository, AppTestimonialRepository>();

            services.AddScoped<IAppWorkManager, AppWorkManager>();
            services.AddScoped<IAppWorkRepository, AppWorkRepository>();


            // Common Dependencies

            return services;
        }
    }
}
