using EntityLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class AppWorkConfiguration : BaseConfiguration<AppWork>
    {
        public override void Configure(EntityTypeBuilder<AppWork> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.WorkID);
        }
    }
}
