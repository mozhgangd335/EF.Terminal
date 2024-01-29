using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal class Traveler
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Traveler(string name, string mobileNumber)
        {

            Name = name;
            MobileNumber = mobileNumber;
        }
    }
}
