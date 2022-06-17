using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class OddNum15_30
    {
        static void Main(string[] args)
        {
         
            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
