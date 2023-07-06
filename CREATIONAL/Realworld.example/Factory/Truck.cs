using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Factory
{
    public class Truck : ITransport
    {
        public string deliver()
        {
            return "delivery by truck";
        }
    }
}