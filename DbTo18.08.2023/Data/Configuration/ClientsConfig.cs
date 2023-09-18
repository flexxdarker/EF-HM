using DbTo18._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Data.Configuration
{
    public class ClientsConfig : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Surname).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Sexs).WithMany(x => x.Clients).HasForeignKey(x => x.SexsId);
            builder.HasOne(x => x.Flights).WithMany(x => x.Clients).HasForeignKey(x => x.FlightsId);
        }
    }
}
