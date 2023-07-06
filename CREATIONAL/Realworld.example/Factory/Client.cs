using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Factory
{
    public class Client
    {
        public void Main(){
            Console.WriteLine("Logistic by Sea");
            ClientCode( new SeaLogistics());

            Console.WriteLine("");
            
            Console.WriteLine("Logistic by road");
            ClientCode( new RoadLogistics());
        }

        public void ClientCode(Logistic logistic){
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + logistic.planDelivery());
        }
    }
}