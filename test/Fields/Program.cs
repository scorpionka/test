using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto() { Distance = 150, Model = "Honda" };
            Console.WriteLine(car.Distance);
            car.Distance = 50;
            CleanAuto(ref car);
            Console.WriteLine(car.Distance);
        }

        static void CleanAuto(ref Auto car)
        {
            car.Distance = 100;
            car = new Auto();
        }
    }
}
