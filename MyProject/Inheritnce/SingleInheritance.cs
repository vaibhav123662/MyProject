using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Parent
    {
  
      public void Display()
        {
            Console.WriteLine("Eating");
        }
    }

    class Child : Parent
    {
        public void show()
        {
            Console.WriteLine("Pav bhaji");
        }
    }
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            Child c= new Child();
            c.Display();
            c.show();
        }
    }
}
