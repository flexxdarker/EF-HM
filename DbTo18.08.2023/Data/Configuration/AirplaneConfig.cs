using Hm18._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Data.Configuration
{
    public class AirplaneConfig : IEntityTypeConfiguration<Airplanes>
    {
        public void Configure(EntityTypeBuilder<Airplanes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Model).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Type).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.MaxPassengers).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Country).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Flights).WithOne(x => x.Airplanes);
        }
    }
}
