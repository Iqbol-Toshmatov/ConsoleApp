using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();
        }
    }

    interface IMovable
    {
        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}

