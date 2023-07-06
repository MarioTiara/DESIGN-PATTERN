using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Factory
{
    public class Ship : ITransport
    {
        public string deliver()
        {
          return "delivery by Ship";
        }
    }
}