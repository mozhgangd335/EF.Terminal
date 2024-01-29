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
    internal class TicketEntityMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.HasOne(_ => _.Travel).WithMany(_ => _.Tickets).HasForeignKey(_ => _.TravelId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(_ => _.Traveler).WithOne(_ => _.Ticket).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(_=>_.Seats).WithOne(_=>_.Ticket).HasForeignKey(_ => _.TicketId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
