
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Table1to5
    {
        static void Main(string[] args)
        {
            int num,result=0;
            for(int i = 1; i <= 5; i++)
            {
                num = i;
                for(int j = 1; j <= 10; j++)
                {
                    result = num * j;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
