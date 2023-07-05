using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public class ModernChair : Chair
    {
        public string name { get; set ; }="ModernChair";

        public bool hasLegs()
        {
           return false;
        }

        public string sitOn()
        {
            return "modern sit on";
        }
    }
}