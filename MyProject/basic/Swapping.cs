using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping a=" +a);
            Console.WriteLine("After Swapping b=" +b);
        }
    }
}
