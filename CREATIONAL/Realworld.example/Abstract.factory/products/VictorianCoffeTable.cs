using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public class VictorianCoffeTable : CoffeTable
    {
        public string name { get ; set ; }="VictorianCoffeTable";

        public int getNumberOfLegs()
        {
            return 4;
        }

        public string getShape()
        {
            return "oval";
        }
    }
}