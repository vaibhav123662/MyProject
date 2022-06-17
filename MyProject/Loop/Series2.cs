using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Series2
    {
        static void Main(string[] args)
        {
     /*Series 0,3,8,15,24*/


            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i*i)-1);
                i++;
            }
        }
    }
}
