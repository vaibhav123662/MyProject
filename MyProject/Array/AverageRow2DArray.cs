using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class AverageRow2DArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 5, 3, 7 }, { 8, 3, 5 } };
            int i;
            for (i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                int j;                
                for (j = 0; j <a.GetLength(1); j++)
                {
                     sum = sum + a[i, j];
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine("sum= "+sum);
                Console.WriteLine("average= "+ (sum/j));
            }
        }
    }
}
