using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Entities;

namespace Terminal
{
    public class EfDbContex :DbContext
    {protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Db_Terminal;Integrated Securitu=True");
        }
         internal DbSet<Bus> Buses { get; set; }
        internal DbSet<Seat> Seats { get; set; }
       internal DbSet<Ticket> Tickets { get; set; }
      internal DbSet<Travel> Travels { get; set; }
       // DbSet<VipTravel> VipTravels { get; set; }
       // DbSet<NormalTravel> NormalTravels { get; set; }
       internal DbSet<Traveler> travelers { get; set; }

    }
    


}
