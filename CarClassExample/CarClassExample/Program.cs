using System;

namespace CarClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a change!
            Console.WriteLine("Hello World!");
            Car car = new Car();

            car.GasLevel = -5.55f;
        }
    }
}
