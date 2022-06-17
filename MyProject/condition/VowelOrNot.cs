using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class VowelOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = Console.ReadLine()[0];

            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine(ch + " is Vowel");
            }

            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine(ch + " is Vowel");
            }

            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is consonent");
            }
        }
    }
}
