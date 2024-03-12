using System;

namespace NCCLabSuravi33
{
    public class BaseClass
    {
        // Base class method
        public virtual void Display()
        {
            Console.WriteLine("BaseClass Display");
        }
    }

    // Derived class inheriting from BaseClass
    public class DerivedClass : BaseClass
    {
        // Override method from base class
        public override void Display()
        {
            // Call base class method using 'base' keyword
            base.Display();
            Console.WriteLine("DerivedClass Display");
        }
    }

    internal class BaseMethod
    {
        public static void Main(string[] args)
        {
            // Create an instance of the derived class
            DerivedClass derivedObj = new DerivedClass();

            // Call the overridden method of the derived class
            derivedObj.Display();
            Console.WriteLine("\nLab No: 5.b \tName: Suravi Shrestha \tRoll No: 33");
        }
    }
}
