using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }

    class Rev
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 4, 3, 2, 1 };
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    /*                    Console.WriteLine(a[i]);*/
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
