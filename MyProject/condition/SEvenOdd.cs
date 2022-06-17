using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class SEvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            switch (num % 2)
            {
                /*if(num%2==0)*/
                case 1:
                    Console.WriteLine("Number is even"+num);
                    break;

                case 2:
                    Console.WriteLine("Number is odd"+num);
                    break;
            }
        }
    }
}
