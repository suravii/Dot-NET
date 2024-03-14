using System;
using System.Collections.Generic;
using System.Linq;

namespace NCCLabSuravi33
{
    internal class Lamda_Linq
    {
        static void Main(string[] args)
        {
            // Sample list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query with lambda expression to filter even numbers
            var evenNumbers = numbers.Where(x => x % 2 == 0);

            // Printing even numbers
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // LINQ query with lambda expression to find numbers greater than 5
            var greaterThanFive = numbers.Where(x => x > 5);

            // Printing numbers greater than 5
            Console.WriteLine("\nNumbers greater than 5:");
            foreach (var num in greaterThanFive)
            {
                Console.WriteLine(num);
            }

            // LINQ query with lambda expression to calculate sum of all numbers
            var sum = numbers.Sum();

            // Printing sum of all numbers
            Console.WriteLine("\nSum of all numbers: " + sum);
            Console.WriteLine("\nLab No.: 14(b)\tName: Suravi Shrestha\tRoll No: 33/26472");
        }
    }
}

