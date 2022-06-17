using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int a, b, result;

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter choice (1-4):");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Addition is = " +result);
                    break;

                case 2:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Substraction is = " + result);
                    break;
                case 3:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Multiplication is = " + result);
                    break;
                case 4:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("division is = " + result);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }


       
    }
}
