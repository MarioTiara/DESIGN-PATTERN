using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public abstract class Logistics
    {
        public abstract ITransport PlanDelivery();
        public string CreateTransport(){
            var transport= this.PlanDelivery();
            var result= $"Logistic: it will delivered by {transport.Deliver()}";
            return result;
        }
    }
}