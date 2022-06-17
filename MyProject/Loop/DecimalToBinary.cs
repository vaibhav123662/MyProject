using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            int num = int.Parse(Console.ReadLine());

            int r, m = 1, bin = 0;
            while (num != 0)
            {
                r = num % 2;
                bin = bin + (r * m);
                m = m * 10;
                num = num / 2;

            }
            Console.WriteLine(bin);
    }
    }
}
