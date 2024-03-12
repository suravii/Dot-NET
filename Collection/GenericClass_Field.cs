using System;

namespace NCCLabSuravi33

{
    public class GenericClass<T>
    {
        // Generic field of type T
        private T genericField;

        // Constructor to initialize the generic field
        public GenericClass(T value)
        {
            genericField = value;
        }

        // Generic method that accepts a parameter of type T and returns a value of type T
        public T GenericMethod(T argument)
        {
            return argument;
        }
    }
    class GenericClass_Field
    {
        static void Main(string[] args)
        {
            // Creating an instance of GenericClass with integer type parameter
            GenericClass<int> intGenericObj = new GenericClass<int>(10);

            // Calling the generic method with integer type argument
            int result = intGenericObj.GenericMethod(5);
            Console.WriteLine("Returned Value from Generic Method: " + result);

            // Creating an instance of GenericClass with string type parameter
            GenericClass<string> stringGenericObj = new GenericClass<string>("Hello, World!");

            // Calling the generic method with string type argument
            string resultString = stringGenericObj.GenericMethod("Goodbye!");
            Console.WriteLine("Returned Value from Generic Method: " + resultString);
            Console.WriteLine("\nLab No.: 11\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }
}