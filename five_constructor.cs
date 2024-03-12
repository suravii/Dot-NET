using System;

namespace NCCLabSuravi33
{
    public class MyClass
    {
        // Default Constructor
        public MyClass()
        {
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized Constructor
        public MyClass(int value)
        {
            Console.WriteLine($"Parameterized Constructor Called with value: {value}");
        }

        // Copy Constructor
        public MyClass(MyClass original)
        {
            Console.WriteLine("Copy Constructor Called");
        }

        // Static Constructor
        static MyClass()
        {
            Console.WriteLine("Static Constructor Called");
        }

        // Private Constructor
        private MyClass(string message)
        {
            Console.WriteLine($"Private Constructor Called with message: {message}");
        }
    }

    internal class five_constructor
    {
        static void Main(string[] args)
        {
            // Default Constructor
            MyClass obj1 = new MyClass();

            // Parameterized Constructor
            MyClass obj2 = new MyClass(10);

            // Copy Constructor
            MyClass obj3 = new MyClass(obj1);

            Console.WriteLine("\nLab No: 01 \tName: Suravi Shrestha \tRoll No: 33");
        }

    }
}
