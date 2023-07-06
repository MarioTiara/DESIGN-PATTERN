using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.builder
{
    public class Main
    {
        public void Run(){
            var director= new Director();
            var carBuilder=new CarBuilder();

            Console.WriteLine("Build SUV");
            director.makeSUV(carBuilder);
            var suvcar=carBuilder.getResult();
            Console.WriteLine($"Seats number:{suvcar.Seats} Engine:{suvcar.Engine} Cumputer:{suvcar.Computer} GPS:{suvcar.GPS}");
            Console.WriteLine("");

            Console.WriteLine("Sport Car");
            director.makeSportsCar(carBuilder);
            var sportcar=carBuilder.getResult();
            Console.WriteLine($"Seats number:{sportcar.Seats} Engine:{sportcar.Engine} Cumputer:{sportcar.Computer} GPS:{sportcar.GPS}");

        }
    }
}