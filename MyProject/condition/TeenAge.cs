using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class TeenAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());

            if(age>=13 && age <= 19)
            {
                Console.WriteLine("Person is in teen age");
            }
            else
            {
                Console.WriteLine("Person is not teen age");
            }
        }
    }

    class TernaryTeenAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());

            /*string result = age >= 13 && age <= 19 ? "Person is in Teen age" : "Person is Not Teen";*/

            string result = age >= 13 ? age <= 19 ? "Person is in Teen age" : "Person is Not Teen": "Person is Not Teen"; 
            
            Console.WriteLine(result);
        }
    }
}
