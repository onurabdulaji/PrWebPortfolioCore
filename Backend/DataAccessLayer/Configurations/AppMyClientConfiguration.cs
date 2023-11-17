using EntityLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    internal class AppMyClientConfiguration : BaseConfiguration<AppMyClient>
    {
        public override void Configure(EntityTypeBuilder<AppMyClient> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.MyClientID);
        }
    }
}
