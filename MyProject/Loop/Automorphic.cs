using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;

            while (num > 0)
            {
                count++;
                num = num / 10;

            }
            //Console.WriteLine(count);

            num = temp;
            int sq = num * num;
            int power = 1;

            for(int i = 1; i <= count; i++)
            {
                power = power * 10;

            }
            //Console.WriteLine(sq+" "+power);

            int end = sq % power;
            Console.WriteLine(sq+" "+"end="+end);

            if (end == num)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("not automorphic");
            }
        }
    }

    class KaprekarNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sq = num * num;
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;

            }
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;

            }
            int division = sq / power;
            int remainder = sq % power;

            int sum = division + remainder;
            if (sum == temp)
            {
                Console.WriteLine("kaprekar");
            }
            else
            {
                Console.WriteLine("not kaprekar");
            }


        }
    }
}
