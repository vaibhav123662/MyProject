using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class MaxElementArray
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 1, 3, 5, 2 };
            int max = a[0];

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Maximum number is= "+max);
        }
    }

    class MinElementArray
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 9, 3, 5, 2 ,7};
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum number is= " + min);
        }
    }
}
