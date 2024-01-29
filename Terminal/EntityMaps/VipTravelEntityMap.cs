using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Entities;

namespace Terminal.EntityMaps
{
    internal class VipTravelEntityMap : IEntityTypeConfiguration<VipTravel>
    {
        public void Configure(EntityTypeBuilder<VipTravel> builder)
        {

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
