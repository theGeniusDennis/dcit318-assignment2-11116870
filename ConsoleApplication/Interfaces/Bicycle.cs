using System;

namespace ConsoleApplication.Interfaces
{
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
