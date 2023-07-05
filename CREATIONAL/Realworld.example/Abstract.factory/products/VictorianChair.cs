using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public class VictorianChair : Chair
    {
        public string name { get; set ; }="VictorianChair";

        public bool hasLegs()
        {
            return true;
        }

        public string sitOn()
        {
            return "Victorian sit on";
        }
    }
}