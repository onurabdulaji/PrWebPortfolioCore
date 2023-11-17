using EntityLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class AppTestimonialConfiguration : BaseConfiguration<AppTestimonial>
    {
        public override void Configure(EntityTypeBuilder<AppTestimonial> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.TestimonialID);
        }
    }
}
