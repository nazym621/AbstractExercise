using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public abstract void Drive();
        
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Wheels = 4;
            Doors = 4;
            Console.WriteLine($"A car drives with {Wheels} wheels and has {Doors} doors");
        }
    }
    public class Motorcyle: Vehicle
    {
        public override void Drive()
        {
            Wheels = 2;
            Doors = 0;
            Console.WriteLine($"A motorcyle drives with {Wheels} wheels and {Doors} doors");
        }
    }
}
