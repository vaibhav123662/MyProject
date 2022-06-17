using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Sum1_10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
