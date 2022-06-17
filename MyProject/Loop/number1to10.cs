using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class number1to10
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    sum = i * i;
                    Console.WriteLine(sum);
                }
                i++;
            }
        }
    }
}
