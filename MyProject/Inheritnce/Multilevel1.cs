using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class GrandFather
    {
        public string name = "Maruti";

    }
    class Father : GrandFather
    {
        public string name1 = "Anil";

    }
    class Child1 :Father
    {
        public string name2 = "Vaibhav";


        public void show()
        {
            Console.WriteLine(name+ "  " + name1 + "  " + name2);
        }
    }
    class Multilevel1
    {
        static void Main(string[] args)
        {
            Child1 c = new Child1();
            c.show();
        }
    }
}
