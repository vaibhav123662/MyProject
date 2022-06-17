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
            
            for(int i = 1; i < a.Length; i=i+2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
