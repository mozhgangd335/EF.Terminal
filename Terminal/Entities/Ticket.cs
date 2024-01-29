using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal class Ticket
    {
        public int Id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public int TravelerId { get; set; }
        public Traveler Traveler { get; set; }
        public HashSet<Seat> Seats { get; set; }


    }
}
