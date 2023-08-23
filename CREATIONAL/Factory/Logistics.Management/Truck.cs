using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public class Truck : ITransport
    {
        public string Deliver() => "{Truck}";
        
    }
}