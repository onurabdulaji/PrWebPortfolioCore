using EntityLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class AppAboutConfiguration : BaseConfiguration<AppAbout>
    {
        public override void Configure(EntityTypeBuilder<AppAbout> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.AboutID);
        }
    }
}
