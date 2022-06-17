using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class OddNum1_20
    {
        static void Main(string[] args)
        {
            
            int count,i;
            for(i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            count = i / 2  ;
            Console.WriteLine("Count of odd number between 1 to 20 is = "+count);

        }
    }
}
