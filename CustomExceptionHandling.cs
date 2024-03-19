using System;

namespace NCCLabSuravi33
{
    public class CustomException : Exception
    {
        // Constructor with a message
        public CustomException(string message) : base(message)
        {
        }
    }
    internal class CustomExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                // Simulate a situation where a custom exception might occur
                int age = -5;

                // Check if age is negative and throw custom exception
                if (age < 0)
                {
                    throw new CustomException("Age cannot be negative.");
                }

                Console.WriteLine("Age: " + age);
            }
            catch (CustomException ex)
            {
                // Handle the custom exception
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Exception occurred: " + ex.Message);
               
            }
            Console.WriteLine("\nLab No.: 15(c)\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }
}
