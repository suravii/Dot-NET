using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCCLabSuravi33
{
        
        class ThrowDemo
        {
            static void DisplayAge(int age)
            {
                if (age > 0)
                {
                    Console.WriteLine("age is: " + age);
                }
                else
                {
                    throw new ArithmeticException("Age cannot be Negative !!!");
                }


            }
            static void Main(string[] args)
            {
                try
                {
                    DisplayAge(19);
                    DisplayAge(-2);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                    Console.WriteLine("\nLab No.: 15(b)\tName: Suravi Shrestha\tRoll No: 33/26472");
                }
            }
        }
    
}
