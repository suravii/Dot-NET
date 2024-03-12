using System;

namespace NCCLabSuravi33
{
    class Animals
    {
        // Virtual method that can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    class Dogs : Animals
    {
        // Override the MakeSound method of the base class
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    // Derived class
    class Cat : Animals
    {
        // Override the MakeSound method of the base class
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class DynamicPoly
    {
        static void Main(string[] args)
        {
            // Creating objects of base and derived classes
            Animals animals1 = new Animals();
            Animals animals2 = new Dogs(); // Upcasting
            Animals animals3 = new Cat(); // Upcasting

            // Calling the MakeSound method on different objects
            animals1.MakeSound(); // Output: Animal makes a sound
            animals2.MakeSound(); // Output: Dog barks
            animals3.MakeSound(); // Output: Cat meows

            Console.WriteLine("\nLab No: 6.b \tName: Suravi Shrestha \tRoll No: 33");
        }
    }

}
