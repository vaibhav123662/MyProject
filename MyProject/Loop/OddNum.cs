using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class OddNum
    {
        static void Main(string[] args)
        {
/*            int num;*/
                for(int i = 15; i <= 30; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
