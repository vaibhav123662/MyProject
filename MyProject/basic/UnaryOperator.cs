using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class UnaryOperator
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int c = 2;

            /*
                        int x = ++a + ++b + a;
                        Console.WriteLine(x + "" + a + "" + b);

                         x = --a + b++;
                        Console.WriteLine(x + "" + a + "" + b);

                         x = a-- - --b - a;
                        Console.WriteLine(x + "" + a + "" + b);

                         x = ++a + --b + b++;
                        Console.WriteLine(x + "" + a + "" + b);*/


            int x = ++a + b++ + c--;
            Console.WriteLine(x + "" + a + "" + b+""+c);


            x = --b - ++a - ++c;
            Console.WriteLine(x + "" + a + "" + b + "" + c);

            x = a-- + b++ - c++ - a;
            Console.WriteLine(x + "" + a + "" + b + "" + c);
        }

    }
}
