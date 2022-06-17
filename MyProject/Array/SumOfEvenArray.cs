using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class SumOfEvenArray
    {
        static void Main(string[] args)
        {
            int [] a = { 1, 5, 2, 6, 3, 4 ,8};
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum of Even From array = "+sum);
        }
    }
}
