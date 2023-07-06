using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.builder
{
    public class Director
    {
       public IBuilder makeSUV(IBuilder builder){
            builder.reset();
            builder.setSeats(6);
            builder.setEngine("SUV Engine");
            builder.setTripComputer();
            builder.setGps();

            return builder;
        }

        public IBuilder makeSportsCar(IBuilder builder){
            builder.reset();
            builder.setSeats(2);
            builder.setEngine("SPORT Engine");
            builder.setTripComputer();
            builder.setGps();
            return builder;
        }

    }
}