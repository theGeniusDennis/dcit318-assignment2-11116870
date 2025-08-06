using System;

namespace ConsoleApplication.Interfaces
{
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
