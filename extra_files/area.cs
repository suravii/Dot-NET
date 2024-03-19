using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(radius);

        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }

    static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}
