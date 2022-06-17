using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class ThisKeyword
    {
        int x;
        public  ThisKeyword():this(60)
        {
            Console.WriteLine(x);
        }

        public ThisKeyword(int x)
        {
            Console.WriteLine("x= "+x);
        }

        public ThisKeyword(string city):this()
        {
            Console.WriteLine(city);
        }
        static void Main(string[] args)
        {
            ThisKeyword t = new ThisKeyword("Ahmednagar");
        }
    }
}
