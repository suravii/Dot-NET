using System;

namespace NCCLabSuravi33
{
    public class BaseClass1
    {
        // Method to be overridden
        public virtual void Display()
        {
            Console.WriteLine("Inside BaseClass Display method");
        }

        // Method to be hidden/shadowed
        public void Show()
        {
            Console.WriteLine("Inside BaseClass Show method");
        }
    }

    public class DerivedClass1 : BaseClass1
    {
        // Method overriding
        public override void Display()
        {
            Console.WriteLine("Inside DerivedClass Display method");
        }

        // Method hiding (shadowing)
        public new void Show()
        {
            Console.WriteLine("Inside DerivedClass Show method");
        }
    }

    internal class Overriding_Hiding
    {
        static void Main(string[] args)
        {
            BaseClass1 baseObj = new BaseClass1();
            baseObj.Display(); // Calls BaseClass Display method
            baseObj.Show();    // Calls BaseClass Show method

            DerivedClass1 derivedObj = new DerivedClass1();
            derivedObj.Display(); // Calls DerivedClass Display method (overridden)
            derivedObj.Show();    // Calls DerivedClass Show method (hidden/shadowed)

            // Upcasting
            BaseClass1 upcastedObj = new DerivedClass1();
            upcastedObj.Display(); // Calls DerivedClass Display method (overridden)
            upcastedObj.Show();    // Calls BaseClass Show method (not overridden)
            Console.WriteLine("\nLab No: 6.a \tName: Suravi Shrestha \tRoll No: 33");
        }

    }
}
