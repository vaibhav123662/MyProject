using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class Leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());

            if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("year is leap");
            }
            else
            {
                Console.WriteLine("Not leap");
            }
        }
    }
}
