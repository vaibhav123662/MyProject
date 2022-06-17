using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
