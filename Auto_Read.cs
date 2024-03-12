using System;

namespace NCCLabSuravi33
{
    public class Person
    {
        // Auto-implemented Property
        public string Name { get; set; }
        // Read-only Property
        public int Age { get; }

        // Constructor to initialize the read-only property
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class Auto_Read
    {

        static void Main(string[] args)
        {
            // Creating an object of Person class
            Person person = new Person("Suravi", 30);

            // Using auto-implemented property
            Console.WriteLine($"Name: {person.Name}");

            // Using read-only property
            Console.WriteLine($"Age: {person.Age}");

            Console.WriteLine("\nLab No: 02 \tName: Suravi Shrestha \tRoll No: 33");
        }
    }
}
