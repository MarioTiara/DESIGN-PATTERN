using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.builder
{
    public class CarBuilder : IBuilder
    {
        private Car car = new Car();
        public void reset()
        {
            this.car= new Car();
        }

        public void setEngine(string engine)
        {
            this.car.Engine=engine;
        }

        public void setGps()
        {
            this.car.GPS=true;
        }

        public void setSeats(int number)
        {
            this.car.Seats=number;
        }

        public void setTripComputer()
        {
            this.car.Computer=true;
        }

        public Car getResult(){
            return this.car;
        }
    }
}