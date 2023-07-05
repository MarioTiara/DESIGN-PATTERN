using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory
{
    public class Client
    {
        public void run(){
            Console.WriteLine("Victorian Factory ..");
            ClientMethod( new VictorianFurnitureFactory());

            Console.WriteLine("modern Factory ..");
            ClientMethod( new ModernFurnitureFactory());
        }

        public void ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.createChair();
            var table =factory.createCoffeeTable();

            Console.WriteLine($"chair: {chair.name} has leg = {chair.hasLegs()} {chair.sitOn()}");
            Console.WriteLine($"table: {table.name} has {table.getNumberOfLegs()} leg(s)  shape = {table.getShape()}");
            
        }
    }
}