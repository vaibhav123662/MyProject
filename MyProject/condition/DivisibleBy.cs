using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class DivisibleBy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 10 == 0)
            {
                Console.WriteLine("Number is Divisible");
            }
            else
            {
                Console.WriteLine("number is not Divisible");
            }
        }
    }
}
