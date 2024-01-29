using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal abstract class Travel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public HashSet<Ticket> Tickets { get; set; }
        public Travel(decimal price, string origin, string destination)

        {
            Origin = origin;
           
            Price = price;
            Destination = destination;

        }
        public abstract void ShowSituations();
        public abstract void BuyTicketTravel();
        public abstract void ReserveTravel();
        public virtual void CancelTravel()
        {

        }

    }
}
