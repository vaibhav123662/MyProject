using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of 5 subjects");
            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int sub4 = int.Parse(Console.ReadLine());
            int sub5 = int.Parse(Console.ReadLine());


            int avg = sub1 + sub2 + sub3 + sub4 + sub5;
            int percentage = avg / 5;


            if (percentage >= 70)
            {
                Console.WriteLine("Student is in Distinction" +percentage);
            }
            else if(percentage>=60 && percentage<70)
            {
                Console.WriteLine("Student is in First class" +percentage);
            }
            else if(percentage>=50 && percentage < 60)
            {
                Console.WriteLine("Student is in second class" +percentage);
            }
            else if(percentage>=36 && percentage<50)
            {
                Console.WriteLine("Pass" +percentage);
            }
            else
            {
                Console.WriteLine("Fail" +percentage);
            }
        }
    }
}
