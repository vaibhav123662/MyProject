using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class Test
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
