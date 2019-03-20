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

            car.GasLevel = 10f;
            car.AddGas(10);

        }
    }
}
