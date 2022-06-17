using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Series
    {
        static void Main(string[] args)
        {
            /*Series 2,12,36*/


            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i*i)+(i*i*i));
                i++;
            }
        }
    }
}
