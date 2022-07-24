using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class ColumnSum2DArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 8, 6 }, { 6, 2, 4 } };
            int i, j;
            int sum;
            for (i = 0; i < a.GetLength(0); i++)
            {
                sum = 0;
                for (j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                }
                Console.WriteLine("sum="+sum);
            }
        }
    }
}
