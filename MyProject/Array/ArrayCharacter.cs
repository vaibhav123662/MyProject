using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class ArrayCharacter
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd', 'e' };

            char[] ch1= { 'a', 'b', 'c', 'd', 'e' };
            for(int i = 0; i < ch1.Length; i++) 
            {
                ch1[i]= Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(ch1);
        }
    }
}
