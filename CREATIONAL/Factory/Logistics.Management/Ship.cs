using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public class Ship : ITransport
    {
        public string Deliver() => "{Ship}";
       
    }
}