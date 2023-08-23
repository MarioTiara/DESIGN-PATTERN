using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Management
{
    public class Client
    {
        public void Main ()
        {
            Console.WriteLine("Logistic: Develiveried by SeaLogistic");
            this.ClientCode( new SeaLogistic());

            Console.WriteLine("");

            Console.WriteLine("Logistic: Deliveried by RoadLogistic");
            ClientCode( new RoadLogistic());
        }
        public void ClientCode (Logistics logistics)=>Console.WriteLine($"Client Result:{logistics.CreateTransport()}");
    }
}