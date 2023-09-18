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
    public class SexsConfig : IEntityTypeConfiguration<Sexs>
    {
        public void Configure(EntityTypeBuilder<Sexs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Sex).IsRequired().HasMaxLength(200);
        }
    }
}
