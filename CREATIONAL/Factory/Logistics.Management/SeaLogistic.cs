using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public class SeaLogistic : Logistics
    {
        public override ITransport PlanDelivery()
        {
            return new Ship();
        }
    }
}