using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class MagicNum
    {
        static void Main(string[] args)
        {
            int magic = 58;
            while (true)
            {
                Console.WriteLine("Enter the number"); ;
                int num = int.Parse(Console.ReadLine());

                if (num > magic)
                {
                    Console.WriteLine("Number is greater than the magic number...plz try again");
                    continue;
                }
                else if (num < magic)
                {
                    Console.WriteLine("Number is less than the magic number...plz try again");
                }
                else
                {
                    Console.WriteLine("Congratulations");
                    break;
                }
            }
        }
    }
}
