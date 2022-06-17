using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Animal1
    {

        public virtual void show()
        {
            Console.WriteLine("Is Sleeping....");
        }
    }
    class Dog1 : Animal1
    {
        public override void show()
        {
            Console.WriteLine("Dog is barking....");
        }
    }
    class Cat : Animal1
    {
        public override void show()
        {
            Console.WriteLine("cat is running....");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Animal1 a = new Dog1();
           a.show();
            Animal1 a1 = new Cat();
            a1.show();
        }
    }
}
