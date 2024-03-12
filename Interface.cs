using System;

namespace NCCLabSuravi33
{
    interface IExample
    {
        void ExampleMethod();
    }

    // Implement the interface in a class
    class ExampleClass : IExample
    {
        public void ExampleMethod()
        {
            Console.WriteLine("This is an example method.");
        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {
            // Create an instance of the class
            ExampleClass exampleObj = new ExampleClass();

            // Call the method through the interface reference
            exampleObj.ExampleMethod();

            Console.WriteLine("\nLab No: 7(b) \tName: Suravi Shrestha \tRoll No: 33");
        }
    }
}
