using DbTo18._08._2023.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Data.Configuration
{
    public class AccountConfig : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Accounts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Login).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
            builder.HasOne(x => x.Clients).WithOne(x => x.Accounts);
        }
    }
}
