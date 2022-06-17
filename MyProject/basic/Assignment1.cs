using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            float total, average, percentage;

            Console.WriteLine("Enter the marks of English :");
            float eng = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Chemistry :");
            float che = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Hindi :");
            float hin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Math :");
            float math = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Biology :");
            float bio = float.Parse(Console.ReadLine());

            total = eng + che + hin + math + bio;
            average = total / 5.0f;
            percentage = (total / 500.0f) * 100;

            Console.WriteLine("Total is ="+total);
            Console.WriteLine("Average is ="+average);
            Console.WriteLine("Percentage is ="+percentage);
        }
    }

    class Output
    {
        /* static void Main(string[] args)
         {
             int a = 5, b = 4, c = 3;

             Console.WriteLine(a++ + b * ++c);
             Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
             Console.WriteLine(b*5/a + b++ + b);
             Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
         }*/


        static void Main(string[] args)
        {
            float a = 10.553f;
            long b = 12L;
            int c;
            c = Convert.ToInt32(a + b);
            Console.WriteLine(c);
        }
    }
}
