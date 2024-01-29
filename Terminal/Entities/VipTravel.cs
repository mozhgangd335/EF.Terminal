using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal class VipTravel : Travel
    {
        public VipTravel(decimal price, string origin,string destination) : base(price, origin,destination)
        {
        }
        public int Id { get; set; }
        public override void BuyTicketTravel()

        {
            throw new NotImplementedException();
        }

        public override void ReserveTravel()
        {
            throw new NotImplementedException();
        }

        public override void ShowSituations()
        {
            throw new NotImplementedException();
        }
    }
}
