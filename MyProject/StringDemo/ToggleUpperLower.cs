using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class ToggleUpperLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]>='a' && str[i] <= 'z')
                {
                    /*str[i]=(char)(str[i]-32);*/
                }
            }
        }
    }
}
