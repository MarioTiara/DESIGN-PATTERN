using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public class RoadLogistic : Logistics
    {
        public override ITransport PlanDelivery()
        {
            return new Truck();
        }
    }
}