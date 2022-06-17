using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class CharCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    Console.WriteLine("Addition is =" + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction is =" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication is =" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division is =" + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }



        }

    }
}
