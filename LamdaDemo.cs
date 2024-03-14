using System;

namespace NCCLabSuravi33
{
    public delegate string GreetDelegate(string name);
    internal class LamdaDemo
    {
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
        static void Main(string[] args)
        {
            LamdaDemo demo = new LamdaDemo();
            GreetDelegate gd = (name) => $"Hello {name}"; // Lambda expression assigned to the delegate
            string msg = gd("Suravi");

            Console.WriteLine(msg); // Printing the message

            Console.WriteLine("\nLab No.: 14(a)\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }
}
