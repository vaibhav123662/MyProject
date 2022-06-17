using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{

    class Executive
    {
        public string dept = "";
        public void Display()
        {
            Console.WriteLine("Executive");
        }
    }

    class Employee : Executive
    {
        public void show()
        {
            dept = "sales";
            Console.WriteLine(dept);
        }
    }
    class Single
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Display();
            e.show();
        }
    }

}
