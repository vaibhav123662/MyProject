using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class StringPalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string reversestr = "";
           
            for(int i = str.Length-1; i >= 0; i--)
            {
                reversestr = reversestr + str[i];
                
            }
            if (str == reversestr)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
            Console.WriteLine();
            //   Console.WriteLine(reversestr);
        }
    }

    
}
