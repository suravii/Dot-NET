using System;

namespace NCCLabSuravi33
{
    public class Animal1
    {
        // Base class constructor
        public Animal1()
        {
            Console.WriteLine("Animal constructor called");
        }

        // Base class constructor with a parameter
        public Animal1(int age)
        {
            Console.WriteLine($"Animal1 constructor called with age {age}");
        }
    }

    // Derived class inheriting from Animal
    public class Dog1 : Animal1
    {
        // Derived class constructor
        public Dog1() : base()
        {
            Console.WriteLine("Dog constructor called");
        }

        // Derived class constructor calling base class constructor with parameter
        public Dog1(string name) : base(5) // Example with a hardcoded age
        {
            Console.WriteLine($"Dog constructor called with name {name}");
        }
    }

    internal class BaseConstructorDemo
    {
        public static void Main(string[] args)
        {
            // Create instances of Dog
            Dog1 dog1 = new Dog1(); // Calls Animal constructor then Dog constructor
            Dog1 dog2 = new Dog1("Buddy"); // Calls Animal constructor with age 5 then Dog constructor with name "Buddy"
            Console.WriteLine("\nLab No: 5.c \tName: Suravi Shrestha \tRoll No: 33");
        }
    }
}
