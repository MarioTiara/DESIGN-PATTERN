using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.builder
{
    public interface IBuilder
    {
        void reset();
        void setSeats(int number);
        void setEngine(string engine);
       void setTripComputer();
       void setGps();
    }
}