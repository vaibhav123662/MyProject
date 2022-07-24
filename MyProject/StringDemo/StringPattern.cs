using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class StringPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            for(int i = 0; i <str.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.WriteLine(str[i]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
