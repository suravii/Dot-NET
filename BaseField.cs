using System;

namespace NCCLabSuravi33
{
    public class Animal
    {
        public string color = "Blue";
    }
    public class Dog : Animal
    {
        string color = "Red"; //same filed as parent
        public void showColor()
        {
            Console.WriteLine(base.color); //parent class color
            Console.WriteLine(color); //child class color
        }
    }

    internal class BaseField
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.showColor();
            Console.WriteLine("\nLab No: 5.a \tName: Suravi Shrestha \tRoll No: 33");
        }
       
    }

}
