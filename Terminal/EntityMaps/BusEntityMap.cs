using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Entities;

namespace Terminal.Models
{
    public class BusEntityMap : IEntityTypeConfiguration<Bus>
    {
       

        void IEntityTypeConfiguration<Bus>.Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasKey(_ => _.BusId);
            builder.Property(_ => _.BusId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.BusName).IsRequired().HasMaxLength(50);
            builder.Property(_ => _.BusType).IsRequired();
        }
    }

}
   

