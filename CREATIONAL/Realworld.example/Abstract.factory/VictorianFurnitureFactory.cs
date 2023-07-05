using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realworld.example.Abstract.factory.products;

namespace Realworld.example.Abstract.factory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair createChair()
        {
            return new VictorianChair();
        }

        public CoffeTable createCoffeeTable()
        {
            return new VictorianCoffeTable();
        }
    }
}