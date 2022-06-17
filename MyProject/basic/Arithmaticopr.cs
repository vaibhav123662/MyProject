using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Arithmaticopr
    {
        static void Main(string[] args)
        {
            int a, b, result;
            a = 10;
            b = 5;

            result = a + b;
            Console.WriteLine("Addition is =" +result);

            result = a - b;
            Console.WriteLine("Substraction is =" + result);

            result = a * b;
            Console.WriteLine("Multiplication is =" + result);

            result = a / b;
            Console.WriteLine("Division is =" + result);

            result = a % b;
            Console.WriteLine("Module is =" + result);

        }
    }
}
