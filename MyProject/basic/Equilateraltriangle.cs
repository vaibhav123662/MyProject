using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.basic
{
    class Equilateraltriangle
    {
        static void Main(string[] args)
        {
            float area;
            Console.WriteLine("Enter the length of side :");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            area = root * side * side;

            Console.WriteLine("Area of equilateral triangle is = "+area);

            /*area = (sqrt(3) / 4) * (s * s);*/


        }
    }
}
