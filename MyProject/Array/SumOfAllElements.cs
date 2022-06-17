using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class SumOfAllElements
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 6, 4, 3, 1 ,1,2};
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i]; 
            }
                Console.WriteLine("Sum of All Elements is= "+sum);
            }
    }
}
