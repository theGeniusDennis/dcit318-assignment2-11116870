using System;
using ConsoleApplication.Inheritance;

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
        }
    }
}
