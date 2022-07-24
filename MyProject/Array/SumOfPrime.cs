using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class SumOfPrime
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            Console.WriteLine("Enter Array elements");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < a.Length; i++)
            {
                bool isPrime = true;
                int n = a[i];
                for(int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    sum = sum + a[i];
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("Sum = "+sum);
        }
    }
}
