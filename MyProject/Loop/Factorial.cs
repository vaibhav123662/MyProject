using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int f = 1, sum = 0;
            
            for(int i = 1; i<= 5; i++)
            {
                f = f * i;
                sum = sum + f;
            }
            Console.WriteLine(sum);
        }
    }
}
