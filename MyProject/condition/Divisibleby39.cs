using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class Divisibleby39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());


            /*if(num%3==0 && num % 9 == 0)
            {
                Console.WriteLine("Divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
*/





            if (num % 3 == 0)
            {
                if (num % 9 == 0)
                {
                    Console.WriteLine("Number is divisible by 3 and 9");
                }
                else
                {
                    Console.WriteLine("Number is divisible by 3 bu not 9");
                }
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
        }
    }
}
