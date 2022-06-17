using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class GreatestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = int.Parse(Console.ReadLine());



            /* if(num1>num2 && num1 > num3)
             {
                 Console.WriteLine("Number One is Greatest");
             }
             else if (num2 > num3)
             {
                 Console.WriteLine("Number two is greatest");
             }
             else
             {
                 Console.WriteLine("Number Three is Greatest");
             }*/



            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number One is Greatest");
                }
                else
                {
                    Console.WriteLine("Number Three is Greatest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number Two is Greatest");
            }
            else
            {
                Console.WriteLine("Number three is largest");
            }
        }
    }
}
