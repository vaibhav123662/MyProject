using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3=0, i;
            Console.WriteLine("Enter The Limit =");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);

                num1 = num2;
                num2 = num3;

            }
        }
    }


    class Freq
    {
        static void Main(string[] args)
        {
            string str = "vaibhav";
            string[] s = str.Split(" ");
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                for(int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count=count+1;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
