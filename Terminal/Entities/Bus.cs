using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Entities
{
    internal class Bus
    {
        public Bus(string busName, Type busType)
        {
            BusName = busName;
            BusType = busType;
        }
        public int BusId { get; set; }
       
        public string BusName { get; set; }
        
        public Type BusType { get; set; }
        public HashSet<Travel> Travels { get; set; }

    }
}
public enum BusTyPE
{
    Vip = 1,
    normal
}
