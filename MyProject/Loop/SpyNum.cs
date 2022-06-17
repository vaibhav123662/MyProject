using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class SpyNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, product = 1, r;

            while (num != 0)
            {
                r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("Number is spy number");
            }
            else
            {
                Console.WriteLine("Number is not spy number");
            }
        }
    }
}
