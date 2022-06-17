using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Science
    {
        public string Subject = "Science";

    }
    class Physics : Science
    {
        public string Subject1 = "Physics";
    }
    class Chemistry : Science
    {
        public string Subject2 = "Chemistry";
    }
    class Biology : Science
    {
        public string Subject3 = "Biology";
    }
    class Hierarchical
    { 
        static void Main(string[] args)
        {
            Physics p = new Physics();
            Console.WriteLine(p.Subject1+"  "+p.Subject);

            Chemistry c = new Chemistry();
            Console.WriteLine(c.Subject2+"  "+c.Subject);

            Biology b = new Biology();
            Console.WriteLine(b.Subject3+"  "+b.Subject);
        }
    }
}
