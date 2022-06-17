
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class AllArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Area \n");

            Console.WriteLine("1.Area of circle");
            Console.WriteLine("2.Area of Triangle");
            Console.WriteLine("3.Area of Rectangle");
            Console.WriteLine("4.Area of square");
            Console.WriteLine("Enter your choice from 1 to 4");
            int choice = int.Parse(Console.ReadLine());
            double area;

            switch (choice)
            {
                case 1:
                        Console.WriteLine("Enter radius of circle");
                    int r = int.Parse(Console.ReadLine());
                    area = 3.14 * r * r;
                    Console.WriteLine("Area of circle is = " +area);
                    break;

                case 2:
                    Console.WriteLine("Enter the base of the triangle");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle");
                    int h = int.Parse(Console.ReadLine());
                    area = 0.5 * b * h;
                    Console.WriteLine("Area of triangle is =" + area);
                    break;

                case 3:
                    Console.WriteLine("Enter the length of rectangle");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width of rectangle");
                    int w = int.Parse(Console.ReadLine());
                    area = l * w;
                    Console.WriteLine("Area of rectangle is =" +area);
                    break;

                case 4:
                    Console.WriteLine("Enter the side of square");
                    int side = int.Parse(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area of square is =" +area);
                    break;

                default :
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
