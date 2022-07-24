using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class ReverseWord
    {
        public static string RevWord(string str)
        {
            string reverse = "";
            string[] s = str.Split(" ");
            for(int i = 1; i < s.Length; i++)
            {
                string words = s[i];
                string reverceword = "";
                for (int j = words.Length-1; j >= 0; j--)
                {
                    reverceword = reverceword + words[j];
                }
                reverse = reverse + " " + reverceword;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string reversenew = RevWord(s);
            Console.WriteLine(reversenew);
        }
    }
}
