using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class TwoDimArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 6, 3, 4, 2 }, {9,4,2,6} };

            for (int i = 0; i <a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0 || (i==j) || j == a.GetUpperBound(1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
