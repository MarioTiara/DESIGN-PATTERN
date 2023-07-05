using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realworld.example.Abstract.factory.products;

namespace Realworld.example.Abstract.factory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair createChair()
        {
                return new ModernChair();
        }

        public CoffeTable createCoffeeTable()
        {
            return new ModernCoffeTable();
        }
    }
}