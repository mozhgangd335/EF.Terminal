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
    internal class TravelerEntityMap : IEntityTypeConfiguration<Traveler>
    {
        public void Configure(EntityTypeBuilder<Traveler> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ =>_.Name).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ =>_.MobileNumber).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
