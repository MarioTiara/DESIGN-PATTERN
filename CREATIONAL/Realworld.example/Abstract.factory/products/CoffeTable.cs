using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public interface CoffeTable
    {
        string name {get;set;}
        int getNumberOfLegs();
        string getShape();
    }
}