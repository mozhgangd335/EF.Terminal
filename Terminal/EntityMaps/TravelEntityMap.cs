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
    internal class TravelEntityMap : IEntityTypeConfiguration<Travel>
    {
        public void Configure(EntityTypeBuilder<Travel> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.Price).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.Origin).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.Destination).IsRequired().ValueGeneratedOnAdd();
            builder.HasOne(_=>_.Bus).WithMany(_=>_.Travels).HasForeignKey(_=>_.BusId).OnDelete(DeleteBehavior.NoAction); 
       
        }
    }
}
