using System;

namespace NCCLabSuravi33

{
    public delegate void RectDelegate(double length, double breadth);
    class MultiCastDelegate
    {
        public void GetArea(double length, double breadth)
        {
            string result = $"\tArea of Rectangle = {length * breadth}";
            Console.WriteLine(result);
        }
        public void GetPerimeter(double length, double breadth)
        {
            string result = $"\tPerimeter of Rectangle = {2 * (length + breadth)}";
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            MultiCastDelegate rectangle = new MultiCastDelegate();
            RectDelegate rd1 = rectangle.GetArea;
            RectDelegate rd2 = rectangle.GetPerimeter;
            RectDelegate rd = rd1 + rd2;//cobines rd1 and rd2
            Console.WriteLine("Rectangle Details:");
            rd.Invoke(14.45, 13.54); //calls both delagates
            rd -= rd1;//removes rd1
            Console.WriteLine("------------------------------------");
            rd.Invoke(102.5, 104.7);//calls only rd2
            Console.WriteLine("\nLab No.: 9(b)\tName: Suravi Shrestha\tRoll No:33/26472");
        }

    }
}