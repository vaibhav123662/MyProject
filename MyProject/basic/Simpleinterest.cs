using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Simpleinterest
    {
        static void Main(string[] args)
        {
            double p, r, t, simpleinterest;

            p = 5000;
            r = 7.5;
            t = 5;
            simpleinterest = (p * r * t) / 100;
            Console.WriteLine(simpleinterest);
        }
    }
}
