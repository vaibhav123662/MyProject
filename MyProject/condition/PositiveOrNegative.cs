using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class PositiveOrNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number :");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("number is Negative");
            }

        }
    }
}
