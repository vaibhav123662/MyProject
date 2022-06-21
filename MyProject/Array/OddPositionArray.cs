using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class OddPositionArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 2, 6, 3, 4, 8 };
            
            for(int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
