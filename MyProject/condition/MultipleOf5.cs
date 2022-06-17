using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class MultipleOf5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("Number is multiple of 5");
            }
            else
            {
                Console.WriteLine("Number is not multiple of 5");
            }
        }
    }

    class TMultipleOf5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            string result = num % 5 == 0 ? "Number is in mutiple of 5" : "Number is not in mutiple of 5";
            Console.WriteLine(result);

        }
    }
}
