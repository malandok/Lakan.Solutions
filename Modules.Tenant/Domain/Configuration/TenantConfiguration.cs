using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.Tenant.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Tenant.Domain.Constants;
using Modules.Tenant.Domain.ValueObjects;

namespace Modules.Tenant.Domain.Configuration
{
    internal sealed class TenantConfiguration : IEntityTypeConfiguration<Entities.Tenant>
    {
        public void Configure(EntityTypeBuilder<Entities.Tenant> builder)
        {
            builder.ToTable(TableNames.Tenant);
            builder.HasKey(x => x.Id);

            builder
             .Property(x => x.Dba)
             .HasConversion(x => x.Value, v => Dba.Create(v).Value)
             .HasMaxLength(Dba.MaxLength);

            builder.HasIndex(x => x.Dba).IsUnique();
        }
    }
}
