using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class MatrixAddition2DArray
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = {{ 1, 2, 3 },{ 4,8,6},{ 6,2,4} };
            int[,] b = { { 3, 5, 9 }, {1,5,3 }, {4,6,2 } };
            int[,] c = new int[3,3];

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(1); j++)
                {
                    Console.WriteLine(a[i,j]);
                }
            }
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(1); j++)
                {
                    Console.WriteLine(b[i, j]);
                }
            }
            for (i = 0; i < a.GetLength(0); i++)
            {
                for(j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
                Console.WriteLine(c[i,j]);
            }
            Console.WriteLine();
        }
    }
}
