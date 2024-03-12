using System;

namespace NCCLabSuravi33
{
    internal class JaggedArr
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]{
    new int[] { 11, 21, 56, 78 },
    new int[] { 2, 5, 6, 7, 98, 5 },
    new int[] { 2, 5 }
};
            // Traverse array elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("\nLab No: 03 \tName: Suravi Shrestha \tRoll No: 33");
        }

    }
}
