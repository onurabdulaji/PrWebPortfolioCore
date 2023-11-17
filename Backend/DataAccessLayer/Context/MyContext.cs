using DataAccessLayer.Configurations;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            //
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppAboutConfiguration());
            builder.ApplyConfiguration(new AppContactConfiguration());
            builder.ApplyConfiguration(new AppMyClientConfiguration());
            builder.ApplyConfiguration(new AppServiceConfiguration());
            builder.ApplyConfiguration(new AppTestimonialConfiguration());
            builder.ApplyConfiguration(new AppWorkConfiguration());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppAbout> AppAbouts { get; set; }
        public DbSet<AppContact> AppContacts { get; set; }
        public DbSet<AppMyClient> AppMyClients { get; set; }
        public DbSet<AppService> AppServices { get; set; }
        public DbSet<AppTestimonial> AppTestimonials { get; set; }
        public DbSet<AppWork> AppWorks { get; set; }
    }
}
