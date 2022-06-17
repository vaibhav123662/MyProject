using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            int rev, sum = 0, temp;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            temp = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum * 10) + rev;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
