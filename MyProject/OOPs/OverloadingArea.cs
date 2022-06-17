using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class OverloadingArea
    {

        void Area(float r)
        {
            Console.WriteLine("Area of circle =" +(3.14*r*r));
        }

        void Area(int l,int w)
        {
            Console.WriteLine("Area of rectangle ="+(l*w));
        }

        void Area(int b,double h)
        {
            Console.WriteLine("Area of tringle= "+(0.5*b*h));
        }
        void Area(int s)
        {
            Console.WriteLine("Area of square ="+(s*s));
        }

        static void Main(string[] args)
        {
            OverloadingArea a = new OverloadingArea();
            a.Area(5);
            a.Area(6, 5);
            a.Area(8, 0.4);
            a.Area(6);
        }
    }
}
