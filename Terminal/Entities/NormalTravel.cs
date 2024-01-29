using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal class NormalTravel : Travel
    {
        public NormalTravel(decimal price, string origin,string destination) : base(price, origin,destination)
        {

        }

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
