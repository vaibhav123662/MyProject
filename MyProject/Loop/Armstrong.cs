using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, r, temp;
            temp = num;

            while (num > 0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Armstrong number");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong number");
            }
        }
    }
}
