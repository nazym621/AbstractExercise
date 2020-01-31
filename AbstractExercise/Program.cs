using System;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var mercedes = new Car();
            mercedes.Drive();

            var abugati = new Motorcyle();
            abugati.Drive();
            
            


            //Console.WriteLine($"A car drives with {Wheels} wheels and has {Doors} doors");
        }
    }
}
