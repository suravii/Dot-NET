using System;
using System.Collections.Generic;

namespace NCCLabSuravi33
{
    public interface IAnimal
    {
        void Eat();
    }

    // Second interface
    public interface IFlyable
    {
        void Fly();
    }

    // Class implementing both interfaces
    public class Bird : IAnimal, IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    internal class MultiInheritance
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Eat(); // Output: Bird is eating
            bird.Fly(); // Output: Bird is flying
            Console.WriteLine("\nLab No: 7(c) \tName: Suravi Shrestha \tRoll No: 33");
        }

    }
}
