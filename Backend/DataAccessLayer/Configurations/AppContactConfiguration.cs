using EntityLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class AppContactConfiguration : BaseConfiguration<AppContact>
    {
        public override void Configure(EntityTypeBuilder<AppContact> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.ContactID);
        }
    }
}
