using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Student
    {
        public string Admission = "Field";

    }
    class Science1:Student
    {
        public string Field1 = "Science";
    }
    class Art:Student
    {
        public string Field2 = "Art";
    }
    class Commerce:Student
    {
        public string Field3 = "Commerce";
    }
    class Hierarchy1
    {
        static void Main(string[] args)
        {
            Science1 s = new Science1();
            Console.WriteLine(s.Admission+ " " +s.Field1);

            Art a = new Art();
            Console.WriteLine(a.Admission + " " + a.Field2);

            Commerce c = new Commerce();
            Console.WriteLine(c.Admission + " " + c.Field3);
        }
    }

}
