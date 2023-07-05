using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realworld.example.Abstract.factory.products;
namespace Realworld.example.Abstract.factory
{
    public interface IFurnitureFactory
    {
        Chair createChair();
        CoffeTable createCoffeeTable();
    }
}