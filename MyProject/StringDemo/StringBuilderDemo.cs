using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.StringDemo
{
    class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);

            sb.Append("Program");
            Console.WriteLine(sb);

            //to create
            StringBuilder sb1 = new StringBuilder("Pune");
            String s = "India";
            StringBuilder sb2 = new StringBuilder(s);
            sb2.Append(" ");
            sb2.Append("Country");
            Console.WriteLine(sb2);

            sb2.Insert(6, "is");
            Console.WriteLine(sb2);

            sb2.Remove(6, 2);
            Console.WriteLine(sb2);

            StringBuilder s1 = new StringBuilder("Hello");
            StringBuilder s2 = new StringBuilder("Hello");
            Console.WriteLine(s1==s2);

            Console.WriteLine(s1.Equals(s2));

            /*string st = sb2.ToString();
            sb2.Reverse();
            Console.WriteLine(sb2);*/
        }
    }
}
