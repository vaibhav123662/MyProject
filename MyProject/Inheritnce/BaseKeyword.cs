using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Animal
    {
        string color = "Black";

        public Animal(string type)
        {
            Console.WriteLine(color + "  " + type);
        }
    }

    class Dog : Animal
    {
        public Dog(int height) : base("Pitbull")
        {
            Console.WriteLine(height);
        }

    }
    class BaseKeyword
    {
    
        static void Main(string[] args)
        {
            Dog d = new Dog(8);
            
        }
    }
}
