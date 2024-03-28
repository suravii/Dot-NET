using System;

namespace NCCLabSuravi33
{
    // Custom class with attributes
    [Serializable]
    [Obsolete("This class is deprecated. Use NewClass instead.")]
    class NewClass
    {
        // Custom method with attributes
        [Obsolete("This method is deprecated. Use NewMethod instead.")]
        public void MyMethod()
        {
            Console.WriteLine("MyMethod is called.");
        }
    }
    internal class BuiltInAttributesDemo
    {
        static void Main(string[] args)
        {
            // Creating an instance of MyClass
            NewClass obj = new NewClass();

            // Calling the deprecated method
            obj.MyMethod();

            // Using reflection to get attributes of MyClass
            Attribute[] classAttributes = Attribute.GetCustomAttributes(typeof(NewClass));

            // Printing class attributes
            Console.WriteLine("Class Attributes:");
            foreach (var attribute in classAttributes)
            {
                Console.WriteLine(attribute.GetType());
            }

            // Using reflection to get attributes of MyMethod
            Attribute[] methodAttributes = Attribute.GetCustomAttributes(typeof(NewClass).GetMethod("MyMethod"));

            // Printing method attributes
            Console.WriteLine("\nMethod Attributes:");
            foreach (var attribute in methodAttributes)
            {
                Console.WriteLine(attribute.GetType());
                Console.WriteLine("\nLab No.: 16(a)\tName: Suravi Shrestha\tRoll No: 33/26472");
            }
        }
    }
}
