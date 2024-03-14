using System;

namespace NCCLabSuravi33
{
    internal class Try_catch
    {
        static void Main()
        {
            try
            {
                // Code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                int index = 5;
                int result = numbers[index]; // Trying to access an index that doesn't exist
                Console.WriteLine("Result: " + result); // This line won't be executed
            }
            catch (IndexOutOfRangeException ex)
            {
                // Catching a specific exception type
                Console.WriteLine("Index is out of range!");
            }
            catch (Exception ex)
            {
                // Catching any other exceptions not caught by previous catch blocks
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Optional block, executes regardless of whether an exception occurred or not
                Console.WriteLine("This block always executes, whether there's an exception or not.");
            }

            Console.WriteLine("Program continues after exception handling.");
            Console.WriteLine("\nLab No.: 15(a)\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }

}

