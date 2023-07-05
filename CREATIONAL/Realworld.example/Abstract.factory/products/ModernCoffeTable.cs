using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public class ModernCoffeTable : CoffeTable
    {
        public string name { get ; set ; }="ModernCoffeTable";

        public int getNumberOfLegs()
        {
            return 1;
        }

        public string getShape()
        {
            return "circular";
        }
    }
}