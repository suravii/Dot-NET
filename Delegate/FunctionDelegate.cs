using System;

namespace NCCLabSuravi33

{
    delegate void MyDelegate(string message);
    class FunctionDelegate
    {
        // Method that matches the delegate signature
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            // Create an instance of the delegate
            MyDelegate myDelegate = new MyDelegate(PrintMessage);

            // Invoke the delegate
            myDelegate("This is an example of Function Delegate.");
            Console.WriteLine("\nLab No.: 9(c)\tName: Suravi Shrestha\tRoll No:33/26472");
        }
    }
}