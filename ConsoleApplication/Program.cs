using System;
using ConsoleApplication.Inheritance;
using ConsoleApplication.Abstraction;
using ConsoleApplication.Interfaces;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding Demo
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound(); // Output: Some generic sound
            dog.MakeSound();           // Output: Bark
            cat.MakeSound();           // Output: Meow

            // Abstract Classes and Methods Demo
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");      // Output: Circle area: 78.54
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}"); // Output: Rectangle area: 24.00
            // Interfaces Demo
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving
        }
    }
}
