using System;

namespace NCCLabSuravi33

{
    class AnonymousMethod
    {
        delegate void MyDelegate(string message);
        static void Main(string[] args)
        {
            // Using an anonymous method with a delegate
            MyDelegate myDelegate = delegate (string message)
            {
                Console.WriteLine("Inside anonymous method: " + message);
            };

            // Invoke the delegate
            myDelegate("Hello, World!");
            Console.WriteLine("\nLab No.: 9(e)\tName: Suravi Shrestha\tRoll No:33/26472");
        }

    }
}