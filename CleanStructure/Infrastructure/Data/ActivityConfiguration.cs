using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Infrastructure.Data
{

    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
        }
    }

    public class PaceActivityConfiguration : IEntityTypeConfiguration<PaceActivity>
    {
        public void Configure(EntityTypeBuilder<PaceActivity> builder)
        {
            builder.ToTable("PaceActivities");
        }
    }

}
