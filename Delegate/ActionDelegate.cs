using System;

namespace NCCLabSuravi33

{
    class ActionDelegate
    {
        static void Main(string[] args)
        {
            // Example 1: Action with no parameters and no return type
            Action printHello = () => Console.WriteLine("Hello!");
            printHello(); // Invoke the action

            // Example 2: Action with parameters and no return type
            Action<string, int> printMessageAndNumber = (message, number) =>
            {
                Console.WriteLine(message);
                Console.WriteLine("Number: " + number);
            };
            printMessageAndNumber("This is Action Delegate.", 33); // Invoke the action
            Console.WriteLine("\nLab No.: 9(d)\tName: Suravi Shrestha\tRoll No:33/26472");
        }

    }
}