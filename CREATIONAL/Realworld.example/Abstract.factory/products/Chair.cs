using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Abstract.factory.products
{
    public interface Chair
    {
        string name {get;set;}
        bool hasLegs();
        string sitOn();
    }
}