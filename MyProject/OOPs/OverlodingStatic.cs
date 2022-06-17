using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class OverlodingStatic
    {
        static void show()
        {
            Console.WriteLine("nbvgh");   
        }
        static void show(int x,int y)
        {
            Console.WriteLine("Add="+(x+y));
        }

        static void show(string s)
        {
            Console.WriteLine("s="+s);
        }

        static void show(double d)
        {
            Console.WriteLine("d ="+d);
        }
        static void Main(string[] args)
        {

            OverlodingStatic.show();
            OverlodingStatic.show(2, 3);
            OverlodingStatic.show("vaibhav");
            OverlodingStatic.show(12.5);
        }
    }
}
